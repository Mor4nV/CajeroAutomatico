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
    public partial class FrmPIN : Form
    {
        public FrmPIN()
        {
            InitializeComponent();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            if (TxtPIN.Text == "")
            {
                MessageBox.Show("Por favor ingrese datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtPIN.Text == "123")
            {
                FrmOperaciones Operaciones = new FrmOperaciones();
                Operaciones.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            TxtPIN.Clear();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmInicio RegresarInicio = new FrmInicio();
            RegresarInicio.Show();
            this.Close();
        }
    }
}
