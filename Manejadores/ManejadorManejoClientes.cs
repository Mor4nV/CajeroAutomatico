using CajeroAutomatico.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Manejadores
{
    internal class ManejadorManejoClientes
    {
        // Aquí irían los métodos para manejar clientes, como agregar, eliminar, actualizar, etc.
        private List<ClaseManejoClientes> ListadoClientes;

        // Constructor
        public ManejadorManejoClientes()
        {
            ListadoClientes = new List<ClaseManejoClientes>();
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
            return true;
        }

        public bool EliminarCliente(string _codigo)
        {
            var cliente = BuscarCliente(_codigo);
            if (cliente != null)
            {
                ListadoClientes.Remove(cliente);
                return true;
            }
            return false;
        }

        public List<ClaseManejoClientes> ObtenerClientesActivos()
        {
            return ListadoClientes.Where(cActivos => cActivos.Estado == 1).ToList();
        }
    }
}

