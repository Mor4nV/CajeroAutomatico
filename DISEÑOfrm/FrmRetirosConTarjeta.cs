using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CajeroAutomatico.DISEÑOfrm;

namespace CajeroAutomatico
{
    public partial class FrmRetirosConTarjeta : Form
    {
        public FrmRetirosConTarjeta()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmOperaciones RegresarMenuOperaciones = new FrmOperaciones();
            RegresarMenuOperaciones.Show();
            this.Close();
        }

        private void Btn100_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn200_Click(object sender, EventArgs e)
        {

        }

        private void Btn300_Click(object sender, EventArgs e)
        {

        }

        private void Btn500_Click(object sender, EventArgs e)
        {

        }

        private void Btn1000_Click(object sender, EventArgs e)
        {

        }

        private void BtnMontoVariable_Click(object sender, EventArgs e)
        {

        }
    }
}
