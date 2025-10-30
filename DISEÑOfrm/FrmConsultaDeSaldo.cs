using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.DiseñoFrm
{
    public partial class FrmConsultaDeSaldo : Form
    {
        public FrmConsultaDeSaldo()
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
