using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Clases
{
    internal class ClaseManejoClientes
    {
        private string strCodigo;
        private string strNombre;
        private string strApellido;
        private string strNumeroCuenta;
        private int intEstado; 

        // Propiedades
        public string Codigo { get { return strCodigo; } }
        public string Nombre { get { return strNombre; } }
        public string Apellido { get { return strApellido; } }
        public string NumeroCuenta { get { return strNumeroCuenta; } }
        public int Estado { get { return intEstado; } }

        // Constructor
        public ClaseManejoClientes(string _codigo, string _nombre, string _apellido, string _cuenta, int _estado)
        {
            this.strCodigo = _codigo;
            this.strNombre = _nombre;
            this.strApellido = _apellido;
            this.strNumeroCuenta = _cuenta;
            this.intEstado = _estado;
        }

        // Método para actualizar la información del cliente
        public void Actualizar(string nuevoNombre, string nuevoApellido, string nuevaCuenta, int nuevoEstado)
        {
            this.strNombre = nuevoNombre;
            this.strApellido = nuevoApellido;
            this.strNumeroCuenta = nuevaCuenta;
            this.intEstado = nuevoEstado;
        }
    }
}

