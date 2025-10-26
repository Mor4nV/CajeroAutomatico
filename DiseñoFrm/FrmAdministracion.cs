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

        }

        private void btnListadoClientes_Click(object sender, EventArgs e)
        {
            FrmListadoClientes formListadoClientes = new FrmListadoClientes();

            formListadoClientes.Show();

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            FrmGenerarReporte formGenerarReporte = new FrmGenerarReporte();

            formGenerarReporte.Show();
        }
    }
}
