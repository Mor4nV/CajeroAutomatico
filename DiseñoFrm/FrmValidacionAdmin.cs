using CajeroAutomatico.Clases;
using CajeroAutomatico.Manejadores;
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
    public partial class FrmValidacionAdmin : Form
    {
        private ManejadorCreacionUsuariosAdmin manejadorAdmin;
        public FrmValidacionAdmin()
        {
            InitializeComponent();
            manejadorAdmin = new ManejadorCreacionUsuariosAdmin();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            frmInicio.Show();
            this.Close();
        }

        private void btnVerificacion_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text.Trim().ToLower();
            string pin = txtPIN.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(pin))
            {
                MessageBox.Show("Debe ingresar el usuario y la contraseña (PIN).",
                    "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var usuarioEncontrado = manejadorAdmin.BuscarUsuario(usuario);

                if (usuarioEncontrado != null && usuarioEncontrado.PINAcceso == pin)
                {

                    ClaseSesionAdmin.UsuarioActual = usuarioEncontrado.NombreUsuario;

                    MessageBox.Show($"Bienvenido {usuarioEncontrado.NombreApellido}. Acceso concedido.",
                        "Validación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    FrmAdministracion frmAdmin = new FrmAdministracion();
                    frmAdmin.Show();
                    txtUsuario.Clear();
                    txtPIN.Clear();
                    txtUsuario.Focus();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o PIN incorrectos. Intente nuevamente.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtPIN.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmValidacionAdmin_Load(object sender, EventArgs e)
        {
            txtPIN.PasswordChar = '*';
        }
    }
}
