using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using CajeroAutomatico.Manejadores;
using CajeroAutomatico.Clases;
using System.IO;
>>>>>>> ParteAdmin

namespace CajeroAutomatico.DISEÑOfrm
{
    public partial class FrmRecargarEfectivo : Form
    {
<<<<<<< HEAD
=======
        private ManejadorRecargarEfectivo manejadorRecarga = new ManejadorRecargarEfectivo();

>>>>>>> ParteAdmin
        public FrmRecargarEfectivo()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
=======

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text))
                {
                    MessageBox.Show("El nombre del empleado es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtMontoReposicion.Text, out decimal montoRecarga) || montoRecarga <= 0)
                {
                    MessageBox.Show("El monto de recarga debe ser un número válido mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string nombreEmpleado = txtNombreEmpleado.Text.Trim();
                DateTime fechaReposicion = dtpFechaReposicion.Value;

                bool agregado = manejadorRecarga.AgregarRecarga(txtNombreEmpleado.Text.Trim(), montoRecarga, fechaReposicion);

                if (agregado)
                {
                    MessageBox.Show("Recarga de efectivo registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la recarga de efectivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la recarga: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmRecargarEfectivo_Load(object sender, EventArgs e)
        {
            dtpFechaReposicion.Value = DateTime.Now;
        }
        
        private void LimpiarCampos()
        {
            txtNombreEmpleado.Clear();
            txtMontoReposicion.Clear();
            dtpFechaReposicion.Value = DateTime.Now;
        }
>>>>>>> ParteAdmin
    }
}
