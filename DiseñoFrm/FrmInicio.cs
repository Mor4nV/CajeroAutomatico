using CajeroAutomatico.Dise�oFrm;

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
            FormAdministracion formAdmin = new FormAdministracion();

            formAdmin.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPIN PIN = new FrmPIN();
            PIN.Show();
            this.Hide();
        }
    }
}
