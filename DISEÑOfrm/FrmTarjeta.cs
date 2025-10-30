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
    public partial class FrmTarjeta : Form
    {
        public FrmTarjeta()
        {
            InitializeComponent();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            FrmRetirosSinTarejta SinTarjeta = new FrmRetirosSinTarejta();
            SinTarjeta.Show();
            this.Close();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            TxtNumeroTarjeta.Clear();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmOperaciones RegresarMenuOperacaiones = new FrmOperaciones();
            RegresarMenuOperacaiones.Show();
            this.Close();
        }
    }
}
