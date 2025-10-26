using CajeroAutomatico.DiseñoFrm;
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
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }

        private void btnRetiros_Click(object sender, EventArgs e)
        {
            FrmRetirosConTarjeta ConTarjeta = new FrmRetirosConTarjeta();
            ConTarjeta.Show();
            this.Hide();
        }

        private void btnSinTarjeta_Click(object sender, EventArgs e)
        {
            FrmRetirosSinTarejta SinTarjeta = new FrmRetirosSinTarejta();
            SinTarjeta.Show();
            this.Hide();
        }

        private void btnTransferencias_Click(object sender, EventArgs e)
        {
            FrmTransferencias Transferencia = new FrmTransferencias();
            Transferencia.Show();
            this.Hide();
        }

        private void btnConcultaSaldo_Click(object sender, EventArgs e)
        {
            FrmConsultaDeSaldo ConTarjeta = new FrmConsultaDeSaldo();
            ConTarjeta.Show();
            this.Hide();
        }

        private void btnHistorialMovimientos_Click(object sender, EventArgs e)
        {
            FrmHistorialDeMovimientos Historial = new FrmHistorialDeMovimientos();
            Historial.Show();
            this.Hide();
        }

        private void btnGestionUsuario_Click(object sender, EventArgs e)
        {
            FrmGestionDeUsuario GestionUsuarios = new FrmGestionDeUsuario();
            GestionUsuarios.Show();
            this.Hide();
        }
    }
}
