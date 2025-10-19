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
    public partial class FormAdministracion : Form
    {
        public FormAdministracion()
        {
            InitializeComponent();
        }

        private void btnManejoClientes_Click(object sender, EventArgs e)
        {
            FormManejoClientes formManejoClientes = new FormManejoClientes();

            formManejoClientes.Show();

        }

        private void btnListadoClientes_Click(object sender, EventArgs e)
        {
            FormListadoClientes formListadoClientes = new FormListadoClientes();

            formListadoClientes.Show();

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            FormGenerarReporte formGenerarReporte = new FormGenerarReporte();

            formGenerarReporte.Show();
        }
    }
}
