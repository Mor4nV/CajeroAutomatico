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
    public partial class FrmRetirosSinTarejta : Form
    {
        public FrmRetirosSinTarejta()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmOperaciones RegresarMenuOperaciones = new FrmOperaciones();
            RegresarMenuOperaciones.Show();
            this.Close();
        }

        private void FrmRetirosSinTarejta_Load(object sender, EventArgs e)
        {
            LblNumero.BackColor = Color.Transparent;
            LblMonto.BackColor = Color.Transparent;

        }
    }
}
