<<<<<<< HEAD
using CajeroAutomatico.DiseñoFrm;
=======
using CajeroAutomatico.DISEÑOfrm;
>>>>>>> Nose1

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
    }
}
