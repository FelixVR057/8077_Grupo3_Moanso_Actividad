using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace _8077_Grupo3_Moanso_Actividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos vacíos
                if (string.IsNullOrWhiteSpace(txtProveedor.Text) ||
                    string.IsNullOrWhiteSpace(txtRuc.Text) ||
                    string.IsNullOrWhiteSpace(txtProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecio.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear entidad
                entCompra c = new entCompra();
                c.Id_Us = 1; // usuario fijo por ahora
                c.Id_Prov = 1; // podrías buscar el proveedor según el RUC más adelante
                c.Id_Mat = 1;  // podrías buscar el material según el producto
                c.Cant_DetComp = Convert.ToInt32(txtCantidad.Text);
                c.PU_DetComp = Convert.ToDecimal(txtPrecio.Text);
                c.Fec_Comp = dateTimePicker1.Value;

                bool ok = logCompra.Instancia.InsertarCompra(c);

                if (ok)
                {
                    MessageBox.Show("Compra registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarCompras();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la compra: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCompra.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una compra para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idComp = Convert.ToInt32(dgvCompra.CurrentRow.Cells["Id_Comp"].Value);

                entCompra c = new entCompra();
                c.Id_Comp = idComp;
                c.Cant_DetComp = Convert.ToInt32(txtCantidad.Text);
                c.PU_DetComp = Convert.ToDecimal(txtPrecio.Text);

                bool ok = logCompra.Instancia.EditarCompra(c);

                if (ok)
                {
                    MessageBox.Show("Compra modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarCompras();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la compra: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la operación actual?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarCampos();
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtProveedor.Clear();
            txtRuc.Clear();
            txtProducto.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txtProveedor.Focus();
        }

        private void ListarCompras()
        {
            try
            {
                var lista = logCompra.Instancia.ListarCompra();
                dgvCompra.DataSource = lista;
                dgvCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvCompra.Columns["Id_Comp"].Visible = false;
                dgvCompra.Columns["Id_Us"].Visible = false;
                dgvCompra.Columns["Id_Prov"].Visible = false;
                dgvCompra.Columns["Id_Mat"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar las compras: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Campos listos para un nuevo registro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCompra.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una compra para anular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idComp = Convert.ToInt32(dgvCompra.CurrentRow.Cells["Id_Comp"].Value);
                if (MessageBox.Show("¿Está seguro de anular esta compra?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool ok = logCompra.Instancia.EliminarCompra(idComp);
                    if (ok)
                    {
                        MessageBox.Show("Compra anulada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarCompras();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al anular la compra: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarCompras();
        }

        private void dgvCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCompra.Rows[e.RowIndex];

                txtProveedor.Text = fila.Cells["Nom_Prov"].Value.ToString();
                txtProducto.Text = fila.Cells["Nom_Mat"].Value.ToString();
                txtCantidad.Text = fila.Cells["Cant_DetComp"].Value.ToString();
                txtPrecio.Text = fila.Cells["PU_DetComp"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(fila.Cells["Fec_Comp"].Value);
            }
        }
    }
}
