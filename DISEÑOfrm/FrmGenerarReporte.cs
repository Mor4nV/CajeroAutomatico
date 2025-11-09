using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CajeroAutomatico.Manejadores;
using CajeroAutomatico.Clases;
using System.IO;

namespace CajeroAutomatico
{
    public partial class FrmGenerarReporte : Form
    {
        private ManejadorRecargarEfectivo manjadorRecEfec = new ManejadorRecargarEfectivo();
        public FrmGenerarReporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var reporteReposicion = manjadorRecEfec.ObtenerRecargas();
                if (reporteReposicion == null || reporteReposicion.Count == 0)
                {
                    MessageBox.Show("No hay datos de reposición de efectivo disponibles para generar el reporte.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string rutaArchivo = @"ArchivosDeDatos\ReporteRecargaEfectivo.txt";
                string carpeta = Path.GetDirectoryName(rutaArchivo);
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }
                using (StreamWriter writer = new StreamWriter(rutaArchivo, false))
                {
                    writer.WriteLine("================================================");
                    writer.WriteLine("...... Reporte de Reposición de Efectivo .......");
                    writer.WriteLine("================================================");
                    writer.WriteLine("");
                    writer.WriteLine($"Fecha de Generación de Reporte:{DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                    writer.WriteLine("");
                    foreach (var recarga in reporteReposicion)
                    {
                        writer.WriteLine("------------------------------------------------");
                        writer.WriteLine($"Código de Recarga: {recarga.CodigoRecarga}");
                        writer.WriteLine($"Nombre del Empleado: {recarga.NombreEmpleado}");
                        writer.WriteLine($"Monto de Recarga: {recarga.MontoRecarga:C}");
                        writer.WriteLine($"Fecha de Recarga: {recarga.FechaRecarga:dd/MM/yyyy HH:mm:ss}");
                        writer.WriteLine("------------------------------------------------");
                    }
                    writer.WriteLine($"Total de Reposiciones: {reporteReposicion.Count}");
                    writer.WriteLine($"Total de Efectivo Colocado: Q{reporteReposicion.Sum(x => x.MontoRecarga):N2}");
                    writer.WriteLine("");
                    writer.WriteLine("=============== Fin del Reporte ================");
                }

                MessageBox.Show("Reporte de reposición de efectivo generado exitosamente en: " + rutaArchivo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("¿Desea abrir el reporte ahora?", "Abrir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = rutaArchivo,
                        UseShellExecute = true
                    });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            try
            {
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
