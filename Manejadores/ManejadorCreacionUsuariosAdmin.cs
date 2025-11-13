using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CajeroAutomatico.Clases;
using CajeroAutomatico.Manejadores;
using System.IO;

namespace CajeroAutomatico.Manejadores
{
    internal class ManejadorCreacionUsuariosAdmin
    {
        private List<ClaseCreacionUsuariosAdmin> listaUsuariosAdmin;
        private readonly string rutaArchivo = @"C:\Users\emora\source\repos\CajeroAutomatico\ArchivosDeDatos\UsuariosAdministrativos.txt";

        private static readonly Random random = new Random();

        public ManejadorCreacionUsuariosAdmin()
        {
            listaUsuariosAdmin = new List<ClaseCreacionUsuariosAdmin>();
            CargarUsuariosDesdeArchivo();
        }

        public void CargarUsuariosDesdeArchivo()
        {
            if (!File.Exists(rutaArchivo))
                return;

            try
            {
                var lineas = File.ReadAllLines(rutaArchivo);
                listaUsuariosAdmin.Clear();

                foreach (var linea in lineas)
                {
                    var datos = linea.Split('|');
                    if (datos.Length == 7)
                    {
                        listaUsuariosAdmin.Add(new ClaseCreacionUsuariosAdmin(
                            datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6]));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los datos desde el archivo: " + ex.Message);
            }
        }

        public void GuardarUsuariosEnArchivo()
        {
            try
            {
                string carpeta = Path.GetDirectoryName(rutaArchivo);
                if (!Directory.Exists(carpeta))
                    Directory.CreateDirectory(carpeta);

                var lineas = listaUsuariosAdmin.Select(c => c.ToFileString()).ToArray();
                File.WriteAllLines(rutaArchivo, lineas);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar los datos en el archivo: " + ex.Message);
            }
        }


        public string GenerarIDUsuario()
        {
            int maxID = 0;

            foreach (var usuario in listaUsuariosAdmin)
            {
                string parteNumerica = new string(usuario.IDUsuario.Where(char.IsDigit).ToArray());

                if (int.TryParse(parteNumerica, out int idNumerico))
                    if (idNumerico > maxID)
                        maxID = idNumerico;
            }

            return $"ADM{(maxID + 1).ToString("D6")}";
        }

        public string GenerarPINAcceso()
        {
            return random.Next(100000, 999999).ToString();
        }


        public bool CrearUsuarioAdmin(string nombreApellido, string nombreUsuario, string correoEmpresarial,
            string numeroTelefono, string codigoEmpresarial, out string pinGenerado)
        {
            pinGenerado = string.Empty;

            if (!codigoEmpresarial.StartsWith("CAOP"))
                throw new InvalidOperationException("El código empresarial debe comenzar con 'CAOP'.");

            if (listaUsuariosAdmin.Any(u => u.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("Ya existe un usuario con el mismo nombre de usuario.");

            if (listaUsuariosAdmin.Any(u => u.CodigoEmpresarial.Equals(codigoEmpresarial, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("Ya existe un usuario con el mismo código empresarial.");

            string idUsuario = GenerarIDUsuario();
            string pinAcceso = GenerarPINAcceso();
            pinGenerado = pinAcceso;

            var nuevoUsuario = new ClaseCreacionUsuariosAdmin(
                idUsuario, nombreApellido, nombreUsuario, correoEmpresarial, numeroTelefono, codigoEmpresarial, pinAcceso);

            listaUsuariosAdmin.Add(nuevoUsuario);
            GuardarUsuariosEnArchivo();
            return true;
        }

        public List<ClaseCreacionUsuariosAdmin> ObtenerListaUsuariosAdmin()
        {
            return listaUsuariosAdmin;
        }

        public ClaseCreacionUsuariosAdmin BuscarUsuario(string nombreUsuario)
        {
            return listaUsuariosAdmin.FirstOrDefault(u =>u.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));
        }

        public bool EliminarUsuario(string nombreUsuario)
        {
            var usuario = BuscarUsuario(nombreUsuario);

            if (usuario == null)
                throw new InvalidOperationException("El usuario no existe.");

     
            if (!usuario.NombreUsuario.Equals(ClaseSesionAdmin.UsuarioActual, StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("Solo puedes eliminar tu propio usuario administrativo.");

            listaUsuariosAdmin.Remove(usuario);
            GuardarUsuariosEnArchivo();
            return true;
        }


        public string ConsultarPIN(string nombreUsuario)
        {
            var usuario = BuscarUsuario(nombreUsuario);
            if (usuario == null)
                throw new InvalidOperationException("Usuario no encontrado.");

  
            if (!usuario.NombreUsuario.Equals(ClaseSesionAdmin.UsuarioActual, StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("Solo puedes consultar tu propio PIN.");

            return usuario.PINAcceso;
        }

        public string CambiarPIN(string nombreUsuario)
        {
            var usuario = BuscarUsuario(nombreUsuario);
            if (usuario == null)
                throw new InvalidOperationException("Usuario no encontrado.");

            if (!usuario.NombreUsuario.Equals(ClaseSesionAdmin.UsuarioActual, StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("Solo puedes cambiar tu propio PIN.");

            string nuevoPIN = GenerarPINAcceso();
            usuario.PINAcceso = nuevoPIN;
            GuardarUsuariosEnArchivo();

            return nuevoPIN;
        }

    }
}
