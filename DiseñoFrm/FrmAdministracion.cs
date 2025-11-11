using CajeroAutomatico.DiseñoFrm;
using CajeroAutomatico.DISEÑOfrm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class FrmAdministracion : Form
    {
        public FrmAdministracion()
        {
            InitializeComponent();
        }

        private void btnManejoClientes_Click(object sender, EventArgs e)
        {
            FrmManejoClientes formManejoClientes = new FrmManejoClientes();

            formManejoClientes.Show();
            this.Hide();

        }

        private void btnListadoClientes_Click(object sender, EventArgs e)
        {
           FrmRecargarEfectivo frmRecargarEfectivo = new FrmRecargarEfectivo();
            frmRecargarEfectivo.Show();
            this.Hide();

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            FrmGenerarReporte formGenerarReporte = new FrmGenerarReporte();

            formGenerarReporte.Show();
            this.Hide();
        }
    }
}
