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

namespace CajeroAutomatico
{
    public partial class FrmManejoClientes : Form
    {
        private ManejadorClientesYCuentas manejadorCC;
        public FrmManejoClientes()
        {
            InitializeComponent();
            manejadorCC = new ManejadorClientesYCuentas();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }


        private void FrmManejoClientes_Load(object sender, EventArgs e)
        {
            dgvListadoClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoClientes.MultiSelect = false;
            CargarListadoClientes();
        }

        private void CargarListadoClientes()
        {
            var clientes = manejadorCC.ObtenerTodosLosClientesYCuentas();
            if (clientes == null || clientes.Count == 0)
            {
                dgvListadoClientes.DataSource = null;
                return;
            }

            dgvListadoClientes.DataSource = null;
            dgvListadoClientes.DataSource = clientes;
            FormatearDGV();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre y apellido del cliente.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verifica si ya existe el ID proporcionado (por precaución)
                var existente = manejadorCC.ObtenerClientePorID(txtID.Text.Trim());
                if (existente != null)
                {
                    MessageBox.Show("Ya existe un cliente con ese ID.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                int estadoCuenta = rbtnActiva.Checked ? 1 : 0;

                // Como aquí no se ingresan todos los datos, ponemos valores por defecto
                manejadorCC.AgregarClienteCuenta(
                    txtNombres.Text.Trim(),
                    txtApellidos.Text.Trim(),
                    "0000000000000",
                    "0000-0000",
                    "sincorreo@correo.com",
                    0,
                    "Ahorros"
                );

                MessageBox.Show("Cliente agregado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarListadoClientes();
                LimpiarTextos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearDGV()
        {
            dgvListadoClientes.Columns["ID"].HeaderText = "ID Cliente";
            dgvListadoClientes.Columns["Nombres"].HeaderText = "Nombres";
            dgvListadoClientes.Columns["Apellidos"].HeaderText = "Apellidos";
            dgvListadoClientes.Columns["NumeroCuenta"].HeaderText = "Número de Cuenta";
            dgvListadoClientes.Columns["EstadoCuenta"].HeaderText = "Estado";
            dgvListadoClientes.Columns["PIN"].Visible = false;
            dgvListadoClientes.Columns["DPI"].Visible = false;
            dgvListadoClientes.Columns["Telefono"].Visible = false;
            dgvListadoClientes.Columns["CorreoElectronico"].Visible = false;
            dgvListadoClientes.Columns["SaldoInicial"].Visible = false;
            dgvListadoClientes.Columns["TipoCuenta"].Visible = false;
        }

        private void LimpiarTextos()
        {
            txtID.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtNumeroCuenta.Clear();
            rbtnActiva.Checked = true;
        }

        private void dgvListadoClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvListadoClientes.Rows.Count)
                return;

            DataGridViewRow fila = dgvListadoClientes.Rows[e.RowIndex];
            txtID.Text = fila.Cells["ID"].Value.ToString();
            txtNombres.Text = fila.Cells["Nombres"].Value.ToString();
            txtApellidos.Text = fila.Cells["Apellidos"].Value.ToString();
            txtNumeroCuenta.Text = fila.Cells["NumeroCuenta"].Value.ToString();

            int estado = Convert.ToInt32(fila.Cells["EstadoCuenta"].Value);
            if (estado == 1)
                rbtnActiva.Checked = true;
            else
                rbtnInactiva.Checked = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = manejadorCC.ObtenerClientePorID(txtID.Text.Trim());
                if (cliente != null)
                {
                    txtNombres.Text = cliente.Nombres;
                    txtApellidos.Text = cliente.Apellidos;
                    txtNumeroCuenta.Text = cliente.NumeroCuenta;
                    rbtnActiva.Checked = cliente.EstadoCuenta == 1;
                    rbtnInactiva.Checked = cliente.EstadoCuenta == 0;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Debe ingresar el ID del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var cliente = manejadorCC.ObtenerClientePorID(txtID.Text);
                if (cliente == null)
                {
                    MessageBox.Show("El cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int nuevoEstado = rbtnActiva.Checked ? 1 : 0;

                bool actualizado = manejadorCC.ActualizarClienteCuenta(
                    txtID.Text,
                    txtNombres.Text,
                    txtApellidos.Text,
                    cliente.DPI,
                    cliente.Telefono,
                    cliente.CorreoElectronico,
                    cliente.TipoCuenta,
                    nuevoEstado,
                    cliente.PIN
                );

                if (actualizado)
                {
                    MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListadoClientes();
                    LimpiarTextos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListadoClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idCliente = dgvListadoClientes.CurrentRow.Cells["ID"].Value.ToString();

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de eliminar este cliente? Esta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                bool exito = manejadorCC.EliminarClienteCuenta(idCliente);
                if (exito)
                {
                    MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListadoClientes();
                    LimpiarTextos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarListadoClientes();
            MessageBox.Show("Listado de clientes actualizado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            dgvListadoClientes.DataSource = manejadorCC.ObtenerTodosLosClientesYCuentas();
            FormatearDGV();
        }

        private void btnMostrarInactivos_Click(object sender, EventArgs e)
        {
            dgvListadoClientes.DataSource = manejadorCC.ObtenerCuentasInactivas();
            FormatearDGV();
        }

        private void btnMostrarActivos_Click(object sender, EventArgs e)
        {
            dgvListadoClientes.DataSource = manejadorCC.ObtenerCuentasActivas();
            FormatearDGV();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmAdministracion formAdmin = new FrmAdministracion();      
            formAdmin.Show();
            this.Close();
        }
    }
}
