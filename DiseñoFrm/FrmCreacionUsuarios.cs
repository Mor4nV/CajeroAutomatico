using CajeroAutomatico.Clases;
using CajeroAutomatico.DISEÑOfrm;
using CajeroAutomatico.Manejadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.DiseñoFrm
{
    public partial class FrmCreacionUsuarios : Form
    {
        private ManejadorCreacionUsuariosAdmin manejadorUsuariosAdmin = new ManejadorCreacionUsuariosAdmin();
        public FrmCreacionUsuarios()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmAdministracion formAdmin = new FrmAdministracion();
            formAdmin.Show();
            this.Close();
        }

        private void dgvUsuariosAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string pin;
                manejadorUsuariosAdmin.CrearUsuarioAdmin(
                    txtNombreYApellido.Text,
                    txtNombreUsuario.Text,
                    txtCorreoElectronico.Text,
                    txtNumeroTelefono.Text,
                    txtCodigoEmpresarial.Text,
                    out pin);

                lblPINGenerado.Text = $"SU PIN ES: {pin}";
                dgvUsuariosAdmin.DataSource = manejadorUsuariosAdmin.ObtenerListaUsuariosAdmin();
                MessageBox.Show("Usuario creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnConsultarPIN_Click(object sender, EventArgs e)
        {
            try
            {
                string pin = manejadorUsuariosAdmin.ConsultarPIN(txtNombreUsuario.Text);
                lblPINGenerado.Text = $"SU PIN ACTUAL ES: {pin}";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el PIN: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void btnCambiarPIN_Click(object sender, EventArgs e)
        {
            try
            {
                string nuevoPIN = manejadorUsuariosAdmin.CambiarPIN(
                    txtNombreUsuario.Text);
                lblPINGenerado.Text = $" NUEVO PIN: {nuevoPIN}";
                MessageBox.Show("PIN cambiado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar el PIN: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEliminarUsuario_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = txtNombreUsuario.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombreUsuario))
                {
                    MessageBox.Show("Debe ingresar el nombre de usuario que desea eliminar.",
                        "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar su usuario administrativo?\nEsta acción no se puede deshacer.",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    bool eliminado = manejadorUsuariosAdmin.EliminarUsuario(nombreUsuario);

                    if (eliminado)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);


                        txtNombreYApellido.Clear();
                        txtNombreUsuario.Clear();
                        txtCorreoElectronico.Clear();
                        txtNumeroTelefono.Clear();
                        txtCodigoEmpresarial.Clear();
                        lblPINGenerado.Text = string.Empty;


                        dgvUsuariosAdmin.DataSource = null;
                        dgvUsuariosAdmin.DataSource = manejadorUsuariosAdmin.ObtenerListaUsuariosAdmin();
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmCreacionUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuariosDGV();

        }
        private void CargarUsuariosDGV()
        {
            dgvUsuariosAdmin.DataSource = null;
            dgvUsuariosAdmin.DataSource = manejadorUsuariosAdmin.ObtenerListaUsuariosAdmin();

            dgvUsuariosAdmin.ReadOnly = true;
            dgvUsuariosAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuariosAdmin.MultiSelect = false;
            dgvUsuariosAdmin.AllowUserToAddRows = false;
            dgvUsuariosAdmin.AllowUserToDeleteRows = false;
            dgvUsuariosAdmin.AllowUserToOrderColumns = false;

            dgvUsuariosAdmin.Columns["IDUsuario"].HeaderText = "ID Usuario";
            dgvUsuariosAdmin.Columns["NombreApellido"].HeaderText = "Nombre y Apellido";
            dgvUsuariosAdmin.Columns["NombreUsuario"].HeaderText = "Usuario";
            dgvUsuariosAdmin.Columns["CorreoEmpresarial"].HeaderText = "Correo";
            dgvUsuariosAdmin.Columns["NumeroTelefono"].HeaderText = "Teléfono";
            dgvUsuariosAdmin.Columns["CodigoEmpresarial"].HeaderText = "Código Empresarial";
            dgvUsuariosAdmin.Columns["PINAcceso"].Visible = false;
        }

       
    }
}
