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
    public partial class FrmGestionDeUsuario : Form
    {
        public FrmGestionDeUsuario()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmOperaciones RegresarMenuOperaciones = new FrmOperaciones();
            RegresarMenuOperaciones.Show();
            this.Close();
        }
    }
}
