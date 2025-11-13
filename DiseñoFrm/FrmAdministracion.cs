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

        private void btnCreacionUsuarios_Click(object sender, EventArgs e)
        {
            FrmCreacionUsuarios formCreacionUsuarios = new FrmCreacionUsuarios();
            formCreacionUsuarios.Show();
            this.Hide();

        }

        private void btnGestionCuentas_Click(object sender, EventArgs e)
        {
            FrmGestionCuentasBancarias formGestionCuentas = new FrmGestionCuentasBancarias();
            formGestionCuentas.Show();
            this.Hide();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar la sesión?",
                "Confirmar cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
