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

namespace CajeroAutomatico
{
    //POSIBLEMENTE TAMBIEN LO HAGAMOS CON BASE DE DATOS MAS ADELANTE.
    public partial class FrmManejoClientes : Form
    {
        private ManejadorManejoClientes manejadorC = new ManejadorManejoClientes();
        public FrmManejoClientes()
        {
            InitializeComponent();
            GuardarClientesGrid();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmManejoClientes_Load(object sender, EventArgs e)
        {

        }
        private void GuardarClientesGrid()
        {
            List<ClaseManejoClientes> listaClientes = manejadorC.ObtenerClientes();
            dgvListadoClientes.DataSource = null;
            dgvListadoClientes.DataSource = listaClientes;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtID.Text;
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                string numeroCuenta = txtNumeroCuenta.Text;
                int estadoCuenta = rbtnActiva.Checked ? 1 : 0;

                //bool agregado = manejadorC.AgregarCliente(codigo, nombres, apellidos, numeroCuenta, "", estadoCuenta);

                /*
                if (agregado)
                {
                    MessageBox.Show("Cliente agregado correctamente");
                    GuardarClientesGrid();
                    LimpiarTextos();
                }
                else
                {
                    MessageBox.Show("Ya existe un cliente con ese código");
                }

                */
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
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
            string buscarCodigo = txtID.Text;
            var cliente = manejadorC.BuscarCliente(buscarCodigo);

            if (cliente != null)
            {
                txtNombres.Text = cliente.Nombre;
                txtApellidos.Text = cliente.Apellido;
                txtNumeroCuenta.Text = cliente.NumeroCuenta;
                if (cliente.Estado == 1)
                {
                    rbtnActiva.Checked = true;
                }
                else
                {
                    rbtnInactiva.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Cliente no encontrado");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigoEliminar = txtID.Text;
            bool eliminado = manejadorC.EliminarCliente(codigoEliminar);
            if (eliminado)
            {
                MessageBox.Show("Cliente eliminado correctamente");
                GuardarClientesGrid();
                LimpiarTextos();
            }
            else
            {
                MessageBox.Show("Cliente no encontrado");
            }

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            GuardarClientesGrid();

        }

        private void dgvListadoClientes_CellCClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvListadoClientes.Rows[e.RowIndex];
                txtID.Text = fila.Cells["Codigo"].Value.ToString();
                txtNombres.Text = fila.Cells["Nombres"].Value.ToString();
                txtApellidos.Text = fila.Cells["Apellidos"].Value.ToString();
                txtNumeroCuenta.Text = fila.Cells["Numero de Cuenta"].Value.ToString();
                int estado = Convert.ToInt32(fila.Cells["Estado de Cuenta"].Value);
                if (estado == 1)
                {
                    rbtnActiva.Checked = true;
                }
                else
                {
                    rbtnInactiva.Checked = true;
                }
            }
        }
    }
}
