using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Clases
{
    internal class ClaseGestionDeUsuario
    {
        //Atributos
        public string StgNombreUsuario;
        public string StgContrasena;
        public string StgBancoAsociado;
        public string StgNumeroCuenta;
        public string StgNumeroDeTarjeta;

        //Constructor
        public ClaseGestionDeUsuario (string NombreUsuario,string Contraseña, string Banco, string NumeroCuenta, string NumeroTarjeta)
        {
            StgNombreUsuario = NombreUsuario;
            StgContrasena = Contraseña;
            StgBancoAsociado = Banco;
            StgNumeroCuenta = NumeroCuenta;
            StgNumeroDeTarjeta = NumeroTarjeta;
        }

    }
}
