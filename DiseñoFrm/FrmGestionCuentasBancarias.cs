using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CajeroAutomatico.Manejadores;
using CajeroAutomatico.Clases;
using System.IO;

namespace CajeroAutomatico.DiseñoFrm
{
    public partial class FrmGestionCuentasBancarias : Form
    {
        private ManejadorClientesYCuentas manejadorCC;
        public FrmGestionCuentasBancarias()
        {
            InitializeComponent();
            manejadorCC = new ManejadorClientesYCuentas();
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvListadoClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmGestionCuentasBancarias_Load(object sender, EventArgs e)
        {
            cmbTipoCuenta.Items.Add("Ahorros");
            cmbTipoCuenta.Items.Add("Corriente");
            cmbTipoCuenta.Items.Add("Inversion");
            cmbTipoCuenta.SelectedIndex = 0;
            CargarCuentas();


        }
        private void CargarCuentas()
        {
            dgvListadoClientes.DataSource = null;
            dgvListadoClientes.DataSource = manejadorCC.ObtenerTodosLosClientesYCuentas();

            dgvListadoClientes.Columns["ID"].HeaderText = "ID";
            dgvListadoClientes.Columns["Nombres"].HeaderText = "Nombres";
            dgvListadoClientes.Columns["Apellidos"].HeaderText = "Apellidos";
            dgvListadoClientes.Columns["DPI"].HeaderText = "DPI";
            dgvListadoClientes.Columns["Telefono"].HeaderText = "Teléfono";
            dgvListadoClientes.Columns["CorreoElectronico"].HeaderText = "Correo Electrónico";
            dgvListadoClientes.Columns["NumeroCuenta"].HeaderText = "Número de Cuenta";
            dgvListadoClientes.Columns["SaldoInicial"].HeaderText = "Saldo Inicial";
            dgvListadoClientes.Columns["TipoCuenta"].HeaderText = "Tipo de Cuenta";
            dgvListadoClientes.Columns["EstadoCuenta"].HeaderText = "Estado (1=Activa, 0=Inactiva)";
            dgvListadoClientes.Columns["PIN"].Visible = false;


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal saldoInicial = 0;
                decimal.TryParse(txtSaldoInicial.Text, out saldoInicial);

                manejadorCC.AgregarClienteCuenta(txtNombres.Text, txtApellidos.Text, txtNumeroDPI.Text,
                    txtNumeroTelefono.Text, txtCorreoElectronico.Text, saldoInicial, cmbTipoCuenta.SelectedItem.ToString());
                MessageBox.Show("Cuenta bancaria agregada exitosamente.");
                CargarCuentas();
                LimpiarCampos();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la cuenta bancaria: " + ex.Message);
            }

        }

        private void btnEdiarInformacion_Click(object sender, EventArgs e)
        {
            if (dgvListadoClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cuenta bancaria para editar.", "Atencion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idCliente = dgvListadoClientes.CurrentRow.Cells["ID"].Value.ToString();
            string nuevoPIN = dgvListadoClientes.CurrentRow.Cells["PIN"].Value.ToString();

            bool exito = manejadorCC.ActualizarClienteCuenta(idCliente, txtNombres.Text, txtApellidos.Text, txtNumeroDPI.Text,
                txtNumeroTelefono.Text, txtCorreoElectronico.Text, cmbTipoCuenta.SelectedItem.ToString(), nuevoPIN);

            if (exito)
            {
                MessageBox.Show("Información actualizada correctamente.");
                CargarCuentas();
            }
            else
            {
                MessageBox.Show("Error al actualizar la información.");

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListadoClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cuenta bancaria para eliminar.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idCliente = dgvListadoClientes.CurrentRow.Cells["ID"].Value.ToString();

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar esta cuenta bancaria?\nEsta acción no se puede deshacer.",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                bool exito = manejadorCC.EliminarClienteCuenta(idCliente);

                if (exito)
                {
                    MessageBox.Show("Cuenta eliminada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCuentas();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la cuenta. Verifique e intente nuevamente.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void LimpiarCampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtNumeroDPI.Clear();
            txtNumeroTelefono.Clear();
            txtCorreoElectronico.Clear();
            txtSaldoInicial.Clear();
            cmbTipoCuenta.SelectedIndex = 0;
        }

        private void dgvListadoClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListadoClientes.CurrentRow != null)
            {
                txtNombres.Text = dgvListadoClientes.CurrentRow.Cells["Nombres"].Value.ToString();
                txtApellidos.Text = dgvListadoClientes.CurrentRow.Cells["Apellidos"].Value.ToString();
                txtNumeroDPI.Text = dgvListadoClientes.CurrentRow.Cells["DPI"].Value.ToString();
                txtNumeroTelefono.Text = dgvListadoClientes.CurrentRow.Cells["Telefono"].Value.ToString();
                txtCorreoElectronico.Text = dgvListadoClientes.CurrentRow.Cells["CorreoElectronico"].Value.ToString();
                txtSaldoInicial.Text = dgvListadoClientes.CurrentRow.Cells["SaldoInicial"].Value.ToString();
                cmbTipoCuenta.Text = dgvListadoClientes.CurrentRow.Cells["TipoCuenta"].Value.ToString();
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmAdministracion formAdmin = new FrmAdministracion();
            formAdmin.Show();
            this.Close();
        }
    }
}
