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
    public partial class FrmLoginPIN : Form
    {
        public FrmLoginPIN()
        {
            InitializeComponent();
        }

        private void BtnPIN_Click(object sender, EventArgs e)
        {
            if (TxtPIN.Text == "")
            {
                MessageBox.Show("Por favor ingrese datos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (TxtPIN.Text == "123")
            {
                FrmOperaciones OperacionesCajero = new FrmOperaciones();
                OperacionesCajero.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmLoginPIN_Load(object sender, EventArgs e)
        {
            PbxContinuar.BackColor = Color.Transparent;
            PbxBorrar.BackColor = Color.Transparent;
            PbxRegresar.BackColor = Color.Transparent;
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
