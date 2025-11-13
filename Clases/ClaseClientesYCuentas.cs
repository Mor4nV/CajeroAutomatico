using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Clases
{
    internal class ClaseClientesYCuentas
    {
        private string strID;
        private string strNombres;
        private string strApellidos;
        private string strDPI;
        private string strTelefono;
        private string strCorreoElectronico;
        private string strNumeroCuenta;
        private decimal decSaldoInicial;
        private string strTipoCuenta;
        private int intEstadoCuenta;
        private string strPIN;

        public string ID { get { return strID; } }
        public string Nombres { get { return strNombres; } set { strNombres = value; } }
        public string Apellidos { get { return strApellidos; } set { strApellidos = value; } }
        public string DPI { get { return strDPI; } set { strDPI = value; } }
        public string Telefono { get { return strTelefono; } set { strTelefono = value; } }
        public string CorreoElectronico { get { return strCorreoElectronico; } set { strCorreoElectronico = value; } }
        public string NumeroCuenta { get { return strNumeroCuenta; } set { strNumeroCuenta = value; } }
        public decimal SaldoInicial { get { return decSaldoInicial; } set { decSaldoInicial = value; } }
        public string TipoCuenta { get { return strTipoCuenta; } set { strTipoCuenta = value; } }
        public int EstadoCuenta { get { return intEstadoCuenta; } set { intEstadoCuenta = value; } }
        public string PIN { get { return strPIN; } set { strPIN = value; } }




        public ClaseClientesYCuentas( string _id, string _nombres, string _apellidos, string _dpi, string _telefono,
            string _correo, string _numeroCuenta, decimal _saldoInicial, string _tipoCuenta, int _estadoCuenta, string _pin)
        {
            this.strID = _id;
            this.strNombres = _nombres;
            this.strApellidos = _apellidos;
            this.strDPI = _dpi;
            this.strTelefono = _telefono;
            this.strCorreoElectronico = _correo;
            this.strNumeroCuenta = _numeroCuenta;
            this.decSaldoInicial = _saldoInicial;
            this.strTipoCuenta = _tipoCuenta;
            this.intEstadoCuenta = _estadoCuenta;
            this.strPIN = _pin;
        }

        public void ActualizarDatos(string nuevosNombres, string nuevosApellidos, string nuevoDPI,
            string nuevoTelefono, string nuevoCorreoElectronico, string nuevoTipoCuenta, int nuevoEstadoCuenta, string nuevoPIN, decimal nuevoSaldo = -1)
        {
            this.strNombres = nuevosNombres;
            this.strApellidos = nuevosApellidos;
            this.strDPI = nuevoDPI;
            this.strTelefono = nuevoTelefono;
            this.strCorreoElectronico = nuevoCorreoElectronico;
            this.strTipoCuenta = nuevoTipoCuenta;
            this.intEstadoCuenta = nuevoEstadoCuenta;
            this.strPIN = nuevoPIN;

            if (nuevoSaldo >= 0)
            {
                this.decSaldoInicial = nuevoSaldo;

            }
        }

        public string ToFileString()
        {
            return $"{strID}|{strNombres}|{strApellidos}|{strDPI}|{strTelefono}|{strCorreoElectronico}|{strNumeroCuenta}|{decSaldoInicial}|{strTipoCuenta}|{intEstadoCuenta}|{strPIN}";
        }




    }
}
