using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Clases
{
    internal class ClaseCreacionUsuariosAdmin
    {
        private string strIDUsuario;
        private string strNombreApellido;
        private string strNombreUsuario;
        private string strCorreoEmpresarial;
        private string strNumeroTelefono;
        private string strCodigoEmpresarial;
        private string strPINAcceso;

        public string IDUsuario { get { return strIDUsuario; } }
        public string NombreApellido { get { return strNombreApellido; } set { strNombreApellido = value; } }
        public string NombreUsuario { get { return strNombreUsuario; } set { strNombreUsuario = value; } }
        public string CorreoEmpresarial { get { return strCorreoEmpresarial; } set { strCorreoEmpresarial = value; } }
        public string NumeroTelefono { get { return strNumeroTelefono; } set { strNumeroTelefono = value; } }
        public string CodigoEmpresarial { get { return strCodigoEmpresarial; } set { strCodigoEmpresarial = value; } }
        public string PINAcceso { get { return strPINAcceso; } set { strPINAcceso = value; } }


        public ClaseCreacionUsuariosAdmin(string _idUsuario, string _nombreApellido, string _nombreUsuario, string _correoEmpresarial,
            string _numeroTelefono, string _codigoEmpresarial, string _pin)
        {
            this.strIDUsuario = _idUsuario;
            this.strNombreApellido = _nombreApellido;
            this.strNombreUsuario = _nombreUsuario;
            this.strCorreoEmpresarial = _correoEmpresarial;
            this.strNumeroTelefono = _numeroTelefono;
            this.strCodigoEmpresarial = _codigoEmpresarial;
            this.strPINAcceso = _pin;

        }

        public void ActualizarDatos(string nuevoNombreApellido, string nuevoNombreUsuario, string nuevoCorreoEmpresarial,
            string nuevoNumeroTelefono, string nuevoCodigoEmpresarial, string nuevoPIN)
        {
            this.strNombreApellido = nuevoNombreApellido;
            this.strNombreUsuario = nuevoNombreUsuario;
            this.strCorreoEmpresarial = nuevoCorreoEmpresarial;
            this.strNumeroTelefono = nuevoNumeroTelefono;
            this.strCodigoEmpresarial = nuevoCodigoEmpresarial;
            this.strPINAcceso = nuevoPIN;
        }

        public string ToFileString()
        {
            return $"{strIDUsuario}|{strNombreApellido}|{strNombreUsuario}|{strCorreoEmpresarial}|{strNumeroTelefono}|{strCodigoEmpresarial}|{strPINAcceso}";
        }
    }
}
