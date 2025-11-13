using CajeroAutomatico.DiseñoFrm;
using CajeroAutomatico.DISEÑOfrm;

namespace CajeroAutomatico
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            FrmValidacionAdmin formAdmin = new FrmValidacionAdmin();

            formAdmin.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPIN PIN = new FrmPIN();
            PIN.Show();
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
