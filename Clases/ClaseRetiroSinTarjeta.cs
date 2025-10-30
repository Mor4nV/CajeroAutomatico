using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Clases
{
    internal class ClaseRetiroSinTarjeta
    {
        //Atributos
        public string StgCodigoAcceso;
        public decimal DecMontoRetiro;
       
        //Constructor
        public ClaseRetiroSinTarjeta(string Codigo, decimal Monto)
        {
            StgCodigoAcceso = Codigo;
            DecMontoRetiro = Monto;
        }
    }
}
