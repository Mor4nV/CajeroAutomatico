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
    internal class ManejadorRecargarEfectivo
    {
        private List<ClaseRecargarEfectivo> ListadoRecargas;
        private string rutaArchivo = @"C:\Users\emora\source\repos\CajeroAutomatico\ArchivosDeDatos\RecargasEfectivo.txt";

        public ManejadorRecargarEfectivo()
        {
            ListadoRecargas = new List<ClaseRecargarEfectivo>();
            CargarRecargasDesdeArchivo();
        }
        
        public void CargarRecargasDesdeArchivo()
        {
            ListadoRecargas.Clear();
            if (!File.Exists(rutaArchivo))
                return;
            var lineas = File.ReadAllLines(rutaArchivo);
            foreach (var linea in lineas)
            {
                try
                {
                    var partes = linea.Split('|');
                    if (partes.Length == 4 && decimal.TryParse(partes[2], out decimal monto) &&
                        DateTime.TryParse(partes[3], out DateTime fecha))
                    {
                        var recarga = new ClaseRecargarEfectivo(partes[0], partes[1], monto, fecha);
                        ListadoRecargas.Add(recarga);

                    }

                }
                catch 
                {
                    continue;
                }
                
            }
        }
        public void GuardarRecargasEnArchivo()
        {
            string carpeta = Path.GetDirectoryName(rutaArchivo);
            if (!string.IsNullOrEmpty(carpeta) && !Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }
            var lineas = ListadoRecargas.Select(r => r.ToFileString()).ToArray();
            File.WriteAllLines(rutaArchivo, lineas);
        }
        public string GenerarCodigoRecarga()
        {
            int siguienteNumero = ListadoRecargas.Count + 1;
            return $"REC{DateTime.Now:yyyyMMdd}{siguienteNumero:D4}";
        }
        public bool AgregarRecarga( string nombreEmpleado, decimal montoRecarga, DateTime fechaRecarga)
        {
            if (string.IsNullOrWhiteSpace(nombreEmpleado) || montoRecarga <= 0)
                throw new ArgumentException("El nombre del empleado es obligatorio y el monto debe ser mayor a cero.");

            string codigo = GenerarCodigoRecarga();

            ClaseRecargarEfectivo nuevaRecarga = new ClaseRecargarEfectivo(codigo, nombreEmpleado, montoRecarga, fechaRecarga);
            ListadoRecargas.Add(nuevaRecarga);
            GuardarRecargasEnArchivo();
            return true;



        }
        public List<ClaseRecargarEfectivo> ObtenerRecargas()
        {
            return ListadoRecargas.ToList();
        }
        public decimal ObtenerTotalRecargado()
        {
            return ListadoRecargas.Sum(r => r.MontoRecarga);
        }
        public void LimpiarRecargas()
        {
            ListadoRecargas.Clear();
            GuardarRecargasEnArchivo();
        }
        public void RefrescarRecargas()
        {
            CargarRecargasDesdeArchivo();
        }


    }
}
