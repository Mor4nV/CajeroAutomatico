using CajeroAutomatico.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CajeroAutomatico.Manejadores
{
    internal class ManejadorManejoClientes
    {
        // Aquí irían los métodos para manejar clientes, como agregar, eliminar, actualizar, etc.
        private List<ClaseManejoClientes> ListadoClientes;
        private string rutaArchivo = @"C:\Users\emora\source\repos\CajeroAutomatico\ArchivosDeDatos\Usuarios.txt";

        // Constructor
        public ManejadorManejoClientes()
        {
            ListadoClientes = new List<ClaseManejoClientes>();
            // Cargar los clientes desde el archivo al iniciar el manejador
            CargarClientesDesdeArchivo();

        }
        private void CargarClientesDesdeArchivo()
        {
            ListadoClientes.Clear();
            
            if (!File.Exists(rutaArchivo))
                return;

            var lineas = File.ReadAllLines(rutaArchivo);
            foreach (var linea in lineas)
            {
                var partes = linea.Split('|');
                if (partes.Length == 5)
                {
                    string codigo = partes[0];
                    string nombre = partes[1];
                    string apellido = partes[2];
                    string cuenta = partes[3];
                    if (int.TryParse(partes[4], out int estado))
                    {
                        ClaseManejoClientes cliente = new ClaseManejoClientes(codigo, nombre, apellido, cuenta, estado);
                        ListadoClientes.Add(cliente);
                    }
                }
            }
        }
        public void GuardarClientesEnArchivo()
        {
            var lineas = ListadoClientes.Select(c => c.ToFileString()).ToArray();
            File.WriteAllLines(rutaArchivo, lineas);
        }



        public bool AgregarCliente(string _codigo, string _nombre, string _apellido, string _cuenta, int _estado)
        {
            if (ListadoClientes.Any(verifiduplicacion => verifiduplicacion.Codigo.Equals(_codigo, StringComparison.OrdinalIgnoreCase)))

                return false;

            // Para validacion de campos obligatorios
            if (string.IsNullOrWhiteSpace(_codigo) || string.IsNullOrWhiteSpace(_nombre))
                throw new ArgumentException("El código y el Nombre del Usuario, con Obligatorios");

            ClaseManejoClientes AgregarCliente = new ClaseManejoClientes(_codigo, _nombre, _apellido, _cuenta, _estado);
            ListadoClientes.Add(AgregarCliente);
            GuardarClientesEnArchivo();

            return true;
        }
       
        public List<ClaseManejoClientes> ObtenerClientes()
        {
            return ListadoClientes.ToList();
        }

        public ClaseManejoClientes BuscarCliente(string _codigo)
        {
            return ListadoClientes.FirstOrDefault(bClientes => bClientes.Codigo.Equals(_codigo, StringComparison.OrdinalIgnoreCase));
        }

        public bool ActualizarCliente(string _codigo, string nuevoNombre, string nuevoApellido, string nuevaCuenta, int nuevoEstado)
        {
            ClaseManejoClientes temporal = BuscarCliente(_codigo);
            if (temporal == null)
                return false;

            temporal.Actualizar(nuevoNombre, nuevoApellido, nuevaCuenta, nuevoEstado);
            GuardarClientesEnArchivo();
            return true;
        }

        public bool EliminarCliente(string _codigo)
        {
            var cliente = BuscarCliente(_codigo);
            if (cliente != null)
            {
                ListadoClientes.Remove(cliente);
                GuardarClientesEnArchivo();
                return true;
            }
            return false;
        }
        public List<ClaseManejoClientes> ObtenerClientesActivos()
        {
            return ListadoClientes.Where(cActivos => cActivos.Estado == 1).ToList();
        }
        public List<ClaseManejoClientes> ObtenerClientesInactivos()
        {
            return ListadoClientes.Where(cInactivos => cInactivos.Estado == 0).ToList();
        }
        public void RefrescarListado()
        {
            CargarClientesDesdeArchivo();
        }

    }
}

