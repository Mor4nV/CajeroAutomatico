using CajeroAutomatico.DiseñoFrm;
using CajeroAutomatico.DISEÑOfrm;
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
            FrmTarjeta ConTarjeta = new FrmTarjeta();
            ConTarjeta.Show();
            this.Close();
        }

        private void btnSinTarjeta_Click(object sender, EventArgs e)
        {
            FrmRetirosSinTarejta SinTarjeta = new FrmRetirosSinTarejta();
            SinTarjeta.Show();
            this.Close();
        }

        private void btnTransferencias_Click(object sender, EventArgs e)
        {
            FrmTransferencias Transferencia = new FrmTransferencias();
            Transferencia.Show();
            this.Close();
        }

        private void btnConcultaSaldo_Click(object sender, EventArgs e)
        {
            FrmConsultaDeSaldo ConTarjeta = new FrmConsultaDeSaldo();
            ConTarjeta.Show();
            this.Close();
        }

        private void btnHistorialMovimientos_Click(object sender, EventArgs e)
        {
            FrmHistorialDeMovimientos Historial = new FrmHistorialDeMovimientos();
            Historial.Show();
            this.Close();
        }

        private void btnGestionUsuario_Click(object sender, EventArgs e)
        {
            FrmGestionDeUsuario GestionUsuarios = new FrmGestionDeUsuario();
            GestionUsuarios.Show();
            this.Close();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmInicio RegresaInicio = new FrmInicio();
            RegresaInicio.Show();
            this.Close();
        }

        private void btnConcultaSaldo_Click_1(object sender, EventArgs e)
        {
            FrmConsultaDeSaldo consultaDeSaldo = new FrmConsultaDeSaldo();
            consultaDeSaldo.Show();
            this.Close();
        }

        private void btnHistorialMovimientos_Click_1(object sender, EventArgs e)
        {
            FrmHistorialDeMovimientos historial= new FrmHistorialDeMovimientos();
            historial.Show();
            this.Close();
        }

        private void btnGestionUsuario_Click_1(object sender, EventArgs e)
        {
            FrmGestionDeUsuario Gestion= new FrmGestionDeUsuario();
            Gestion.Show();
            this.Close();
        }
    }
}
