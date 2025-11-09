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
        private ManejadorManejoClientes manejadorC = new ManejadorManejoClientes();
        public FrmManejoClientes()
        {
            InitializeComponent();
            manejadorC = new ManejadorManejoClientes();
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
            var clientes = manejadorC.ObtenerClientes();
            if (clientes == null || clientes.Count == 0)
            {
                dgvListadoClientes.DataSource = null;
                return;
            }
            dgvListadoClientes.DataSource = null;
            dgvListadoClientes.DataSource = clientes;
            FormatearDGV();

        }
        private void FormatearDGV()
        {
            dgvListadoClientes.Columns["Codigo"].HeaderText = "ID Cliente";
            dgvListadoClientes.Columns["Nombre"].HeaderText = "Nombres";
            dgvListadoClientes.Columns["Apellido"].HeaderText = "Apellidos";
            dgvListadoClientes.Columns["NumeroCuenta"].HeaderText = "Número de Cuenta";
            dgvListadoClientes.Columns["Estado"].HeaderText = "Estado";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int estado = rbtnActiva.Checked ? 1 : 0;
                bool agregado = manejadorC.AgregarCliente(txtID.Text.Trim(), txtNombres.Text.Trim(),
                    txtApellidos.Text.Trim(), txtNumeroCuenta.Text.Trim(), estado);
                if (agregado)
                {
                    MessageBox.Show("Cliente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("El cliente con el ID proporcionado ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                CargarListadoClientes();
                LimpiarTextos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarTextos()
        {
            txtID.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtNumeroCuenta.Clear();
            rbtnActiva.Checked = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = manejadorC.BuscarCliente(txtID.Text.Trim());
                if (cliente != null)
                {
                    txtNombres.Text = cliente.Nombre;
                    txtApellidos.Text = cliente.Apellido;
                    txtNumeroCuenta.Text = cliente.NumeroCuenta;
                    rbtnActiva.Checked = cliente.Estado == 1;
                    rbtnInactiva.Checked = cliente.Estado == 0;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                bool eliminado = manejadorC.EliminarCliente(txtID.Text.Trim());
                if (eliminado)
                {
                    MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el cliente. Verifique que el ID exista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CargarListadoClientes();
                LimpiarTextos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            manejadorC.RefrescarListado();
            CargarListadoClientes();
            MessageBox.Show("Listado de clientes actualizado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dgvListadoClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvListadoClientes.Rows.Count)
                return;


            DataGridViewRow fila = dgvListadoClientes.Rows[e.RowIndex];
            txtID.Text = fila.Cells["Codigo"].Value.ToString();
            txtNombres.Text = fila.Cells["Nombre"].Value.ToString();
            txtApellidos.Text = fila.Cells["Apellido"].Value.ToString();
            txtNumeroCuenta.Text = fila.Cells["NumeroCuenta"].Value.ToString();
            int estado = Convert.ToInt32(fila.Cells["Estado"].Value);
            if (estado == 1)
            {
                rbtnActiva.Checked = true;
            }
            else
            {
                rbtnInactiva.Checked = true;
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int estado = rbtnActiva.Checked ? 1 : 0;
                bool actualizado = manejadorC.ActualizarCliente(txtID.Text.Trim(), txtNombres.Text.Trim(),
                    txtApellidos.Text.Trim(), txtNumeroCuenta.Text.Trim(), estado);
                if (actualizado)
                {
                    MessageBox.Show("Cliente actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el cliente. Verifique que el ID exista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CargarListadoClientes();
                LimpiarTextos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            dgvListadoClientes.DataSource = null;
            dgvListadoClientes.DataSource = manejadorC.ObtenerClientes();
            FormatearDGV();


        }

        private void btnMostrarInactivos_Click(object sender, EventArgs e)
        {
            dgvListadoClientes.DataSource = null;
            dgvListadoClientes.DataSource = manejadorC.ObtenerClientesInactivos();
            FormatearDGV();

        }

        private void btnMostrarActivos_Click(object sender, EventArgs e)
        {
            dgvListadoClientes.DataSource = null;
            dgvListadoClientes.DataSource = manejadorC.ObtenerClientesActivos();
            FormatearDGV();

        }
    }
}
