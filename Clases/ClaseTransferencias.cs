﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Clases
{
    internal class ClaseTransferencias
    {
        //Atributos
        public string StgCuentaOrigen;
        public string StgCuentaDestino;
        public decimal DecMontoTransferencia;

        //Constructor
        public ClaseTransferencias(string DeCuenta, string ParaCuenta, decimal Monto)
        {
            StgCuentaOrigen = DeCuenta;
            StgCuentaDestino = ParaCuenta;
            DecMontoTransferencia = Monto;
        }
    }
}
