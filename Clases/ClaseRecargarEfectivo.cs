using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Clases
{
    internal class ClaseRecargarEfectivo
    {
        private string strCodigoRecarga;
        private string strNombreEmpleado;
        private decimal decMontoRecarga;
        private DateTime dtFechaRecarga;

        // Propiedades
        public string CodigoRecarga { get { return strCodigoRecarga; } }
        public string NombreEmpleado { get { return strNombreEmpleado; } set { strNombreEmpleado = value; } }
        public decimal MontoRecarga { get { return decMontoRecarga; } }
        public DateTime FechaRecarga { get { return dtFechaRecarga; } }

        // Constructor

        public ClaseRecargarEfectivo() { }
        public ClaseRecargarEfectivo(string codigoRecarga, string nombreEmpleado, decimal montoRecarga, DateTime fechaRecarga)
        {
            this.strCodigoRecarga = codigoRecarga;
            this.strNombreEmpleado = nombreEmpleado;
            this.decMontoRecarga = montoRecarga;
            this.dtFechaRecarga = fechaRecarga;
        }
        public override string ToString()
        {
            return $"Código Recarga: {strCodigoRecarga}| Empleado: {strNombreEmpleado}| Monto: {decMontoRecarga}| Fecha: {dtFechaRecarga: dd/MM/yyyy HH:mm:ss}";
        }
        public string ToFileString()
        {
            return $"{strCodigoRecarga}|{strNombreEmpleado}|{decMontoRecarga}|{dtFechaRecarga:dd/MM/yyyy HH:mm:ss}";
        }


    }


}

