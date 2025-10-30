using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Clases
{
    internal class ClaseRetiroConTarjeta
    {
        //Atributos
        public string StgNumeroTarjeta;
        public decimal DecMontoRetiro;

        //Constructor
        public ClaseRetiroConTarjeta(string Numero, decimal Monto)
        {
            StgNumeroTarjeta = Numero;
            DecMontoRetiro = Monto;
        }

    }

}
