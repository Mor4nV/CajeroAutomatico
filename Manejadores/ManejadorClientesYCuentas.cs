using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CajeroAutomatico.Clases;
using System.IO;

namespace CajeroAutomatico.Manejadores
{
    internal class ManejadorClientesYCuentas
    {
        private List<ClaseClientesYCuentas> listaClientesYCuentas;
        private string rutaArchivo = @"C:\Users\emora\source\repos\CajeroAutomatico\ArchivosDeDatos\ClientesYCuentas.txt";
        public ManejadorClientesYCuentas()
        {
            listaClientesYCuentas = new List<ClaseClientesYCuentas>();
            CargarDesdeArchivo();
        }
        private static Random random = new Random();
        private void CargarDesdeArchivo()
        {
            listaClientesYCuentas.Clear();
            if (!File.Exists(rutaArchivo))
            {
                return;
            }
            var lineas = File.ReadAllLines(rutaArchivo);
            foreach (var linea in lineas)
            {
                var datos = linea.Split('|');
                if (datos.Length == 11)
                {
                    string id = datos[0];
                    string nombres = datos[1];
                    string apellidos = datos[2];
                    string dpi = datos[3];
                    string telefono = datos[4];
                    string correo = datos[5];
                    string numeroCuenta = datos[6];
                    decimal.TryParse(datos[7], out decimal saldoInicial);
                    string tipoCuenta = datos[8];
                    int.TryParse(datos[9], out int estadoCuenta);
                    string pin = datos[10];

                    var clienteCuenta = new ClaseClientesYCuentas(id, nombres, apellidos, dpi, telefono, correo, numeroCuenta,
                        saldoInicial, tipoCuenta, estadoCuenta, pin);
                    listaClientesYCuentas.Add(clienteCuenta);



                }
            }
        }
        public void GuardarEnArchivo()
        {
            try
            {
                string carpeta = Path.GetDirectoryName(rutaArchivo);
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }

                var lineas = listaClientesYCuentas.Select(c => c.ToFileString()).ToArray();
                File.WriteAllLines(rutaArchivo, lineas);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar los datos en el archivo: " + ex.Message);
            }
        }
        public string GenerarNuevoID()
        {
            int maxID = 0;
            foreach (var clienteCuenta in listaClientesYCuentas)
            {
                string parteNumerica = new string(clienteCuenta.ID.Where(char.IsDigit).ToArray());

                if (int.TryParse(parteNumerica, out int idNumerico))
                {
                    if (idNumerico > maxID)
                    {
                        maxID = idNumerico;
                    }
                }
            }
            return $"CLT{(maxID + 1).ToString("D5")}";


        }


        public string GenerarNumeroCuenta()
        {
            string numeroCuenta;
            do
            {
                numeroCuenta = random.Next(100000000, 999999999).ToString();
            } while (listaClientesYCuentas.Any(c => c.NumeroCuenta == numeroCuenta));
            return numeroCuenta;
        }
        public string GenerarPIN()
        {
            return random.Next(1000, 9999).ToString();
        }
        
        public bool AgregarClienteCuenta(string nombres, string apellidos, string dpi, string telefono,
            string correo, decimal saldoInicial, string tipoCuenta)
        {
            if (string.IsNullOrWhiteSpace(nombres) || string.IsNullOrWhiteSpace(apellidos))
                throw new ArgumentException("El nombre y apellido no pueden estar vacíos.");

            if (listaClientesYCuentas.Any(c => c.DPI == dpi))
                throw new InvalidOperationException("Ya existe un cliente con el mismo DPI.");

            string nuevoID = GenerarNuevoID();
            string nuevoNumeroCuenta = GenerarNumeroCuenta();
            string nuevoPIN = GenerarPIN();
            int estadoCuenta = 1; //INICIA ACTIVA POR DEFECTO

            var nuevoClienteCuenta = new ClaseClientesYCuentas(nuevoID, nombres, apellidos, dpi, telefono,
                correo, nuevoNumeroCuenta, saldoInicial, tipoCuenta, estadoCuenta, nuevoPIN);

            listaClientesYCuentas.Add(nuevoClienteCuenta);
            GuardarEnArchivo();

            return true;


        }
        // Sobrecarga para formularios que no modifican el estado de la cuenta
        public bool ActualizarClienteCuenta(string id, string nuevosNombres, string nuevosApellidos, string nuevoDPI,
            string nuevoTelefono, string nuevoCorreoElectronico, string nuevoTipoCuenta, string nuevoPIN)
        {
            try
            {
                var clienteCuenta = ObtenerClientePorID(id);
                if (clienteCuenta == null)
                    return false;

                // Usamos el mismo estado que ya tenía
                int estadoActual = clienteCuenta.EstadoCuenta;

                clienteCuenta.ActualizarDatos(nuevosNombres, nuevosApellidos, nuevoDPI,
                    nuevoTelefono, nuevoCorreoElectronico, nuevoTipoCuenta, estadoActual, nuevoPIN);

                GuardarEnArchivo();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public ClaseClientesYCuentas ObtenerClientePorID(string id)
        {
            return listaClientesYCuentas.FirstOrDefault(c => c.ID.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        public bool ActualizarClienteCuenta(string id, string nuevosNombres, string nuevosApellidos, string nuevoDPI,
            string nuevoTelefono, string nuevoCorreoElectronico, string nuevoTipoCuenta, int nuevoEstadoCuenta, string nuevoPIN)
        {
            try
            {
                var clienteCuenta = ObtenerClientePorID(id);
                if (clienteCuenta == null)
                    return false;
                clienteCuenta.ActualizarDatos(nuevosNombres, nuevosApellidos, nuevoDPI,
                    nuevoTelefono, nuevoCorreoElectronico, nuevoTipoCuenta, nuevoEstadoCuenta, nuevoPIN);
                GuardarEnArchivo();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool EliminarClienteCuenta(string id)
        {
            try
            {
                var clienteCuenta = ObtenerClientePorID(id);
                if (clienteCuenta == null)
                    return false;
                listaClientesYCuentas.Remove(clienteCuenta);
                GuardarEnArchivo();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public List<ClaseClientesYCuentas> ObtenerTodosLosClientesYCuentas()
        {
            return new List<ClaseClientesYCuentas>(listaClientesYCuentas);
        }

        public List<ClaseClientesYCuentas> ObtenerCuentasActivas()
        {
            return listaClientesYCuentas.Where(c => c.EstadoCuenta == 1).ToList();

        }

        public List<ClaseClientesYCuentas> ObtenerCuentasInactivas()
        {
            return listaClientesYCuentas.Where(c => c.EstadoCuenta == 0).ToList();
        }
    }
}
