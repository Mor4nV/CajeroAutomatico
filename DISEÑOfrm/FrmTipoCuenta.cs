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
    public partial class FrmTipoCuenta : Form
    {
        public FrmTipoCuenta()
        {
            InitializeComponent();
        }

        private void BtnMonetaria_Click(object sender, EventArgs e)
        {
            FrmRetirosConTarjeta SinTarjeta = new FrmRetirosConTarjeta();
            SinTarjeta.Show();
            this.Close();
        }

        private void BtnAhorro_Click(object sender, EventArgs e)
        {
            FrmRetirosConTarjeta SinTarjeta = new FrmRetirosConTarjeta();
            SinTarjeta.Show();
            this.Close();
        }
    }
}
