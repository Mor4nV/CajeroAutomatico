namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {
        public Form1()
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
            FormOperaciones formUser = new FormOperaciones();

            formUser.Show();

        }
    }
}
