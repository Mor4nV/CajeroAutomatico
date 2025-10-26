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
            FrmAdministracion formAdmin = new FrmAdministracion();

            formAdmin.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLoginPIN formUser = new FrmLoginPIN();

            formUser.Show();

        }
    }
}
