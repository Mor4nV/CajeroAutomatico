using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.DISEÑOfrm
{
    public partial class FrmValidacionAdmin : Form
    {
        public FrmValidacionAdmin()
        {
            InitializeComponent();
        }

        private void btnVerificacion_Click(object sender, EventArgs e)
        {
            FrmAdministracion formAdminClientes = new FrmAdministracion();
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "admin123")
            {
                formAdminClientes.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Inténtelo de nuevo.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grpValidacion_Enter(object sender, EventArgs e)
        {

        }
    }
}
