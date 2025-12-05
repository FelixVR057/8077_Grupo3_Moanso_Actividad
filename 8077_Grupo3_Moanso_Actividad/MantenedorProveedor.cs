using CapaLogica;
using System;
using CapaEntidad;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8077_Grupo3_Moanso_Actividad
{
    public partial class MantenedorProveedor : Form
    {
        private int idSeleccionado = 0;
        public MantenedorProveedor()
        {
            InitializeComponent();
            CargarTabla();

        }

        private void MantenedorProveedor_Load(object sender, EventArgs e)
        {

        }
            private int idProveedorSeleccionado = 0;

            // --- 1. MÉTODO PARA CARGAR LA TABLA ---
            private void CargarTabla()
            {
                logProveedor logica = new logProveedor();
                try
                {
                // Asumiendo que tu DataGridView se llama 'dgvProveedores'
                // Si tienes un método Listar en tu lógica, úsalo aquí.
                // Si no lo tienes aún, comenta estas líneas hasta crearlo.
                // dgvProveedores.DataSource = logica.ListarProveedor(); 
                dgvProveedor.DataSource = logica.ListarProveedor();
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar lista: " + ex.Message);
                }
            }

            private void FormProveedor_Load(object sender, EventArgs e)
            {
                CargarTabla();
            }

            // --- 2. BOTÓN NUEVO (Funciona como GUARDAR) ---
            private void btnNuevoProv_Click(object sender, EventArgs e)
            {
                try
                {
                    entProveedor obj = new entProveedor();
                    obj.Codigo = txtCodigoProv.Text;
                    obj.RUC = txtRucProv.Text;
                    obj.Nombre = txtNombreProv.Text;
                    obj.Telefono = txtTelefonoProv.Text;
                    obj.Direccion = txtDireccionProv.Text;
                    obj.FechaRegistro = DateTime.Now; // O el valor de tu DatePicker

                    logProveedor logica = new logProveedor();
                    logica.RegistrarProveedor(obj);

                    MessageBox.Show("¡Proveedor registrado con éxito!");

                    CargarTabla(); // Actualizar la tabla
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        // --- 3. BOTÓN MODIFICAR ---
        private void btnModificar_Click(object sender, EventArgs e)
        {
           
        }
        private void BtnInhabilitarProveedor_Click(object sender, EventArgs e)
            {
            try
            {
                if (idSeleccionado == 0)
                {
                    MessageBox.Show("Por favor, selecciona un proveedor para eliminar.");
                    return;
                }

                if (MessageBox.Show("¿Seguro que deseas eliminar este proveedor?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    logProveedor logica = new logProveedor();
                    logica.EliminarProveedor(idSeleccionado); // Pasamos solo el ID

                    MessageBox.Show("Proveedor eliminado.");

                    CargarTabla();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

            // --- 5. EVENTO PARA SELECCIONAR DE LA TABLA ---
            // Debes ir al diseño, seleccionar el DataGridView, ir a Eventos (el rayito) 
            // y hacer doble clic en "CellClick" o "CellContentClick"
            private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
            {
            if (e.RowIndex >= 0)
            {
                // 1. Guardamos el ID de la fila seleccionada (IMPORTANTE)
                // Asegúrate que tu columna en la BD se llama "IdProveedor"
                idSeleccionado = Convert.ToInt32(dgvProveedor.Rows[e.RowIndex].Cells["IdProveedor"].Value);

                // 2. Llenamos las cajas de texto para que puedas editar
                txtCodigoProv.Text = dgvProveedor.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                txtRucProv.Text = dgvProveedor.Rows[e.RowIndex].Cells["RUC"].Value.ToString();
                txtNombreProv.Text = dgvProveedor.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtTelefonoProv.Text = dgvProveedor.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                txtDireccionProv.Text = dgvProveedor.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();

                // Si tienes fecha, también pásala (opcional)
                // dtpFecha.Value = Convert.ToDateTime(dgvProveedor.Rows[e.RowIndex].Cells["FechaRegistro"].Value);
            }
        }

            // Método auxiliar para limpiar
            private void LimpiarCampos()
            {
                txtCodigoProv.Text = "";
                txtRucProv.Text = "";
                txtNombreProv.Text = "";
                txtTelefonoProv.Text = "";
                txtDireccionProv.Text = "";
                idProveedorSeleccionado = 0;
            }

        private void btnModificarProv_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSeleccionado == 0)
                {
                    MessageBox.Show("Por favor, selecciona un proveedor de la tabla primero.");
                    return;
                }

                entProveedor obj = new entProveedor();
                // AQUÍ ESTÁ EL TRUCO: Usamos el ID que guardamos al hacer clic
                obj.IdProveedor = idSeleccionado;

                obj.Codigo = txtCodigoProv.Text;
                obj.RUC = txtRucProv.Text;
                obj.Nombre = txtNombreProv.Text;
                obj.Telefono = txtTelefonoProv.Text;
                obj.Direccion = txtDireccionProv.Text;

                logProveedor logica = new logProveedor();
                logica.EditarProveedor(obj); // Asegúrate que este método llame al UPDATE en BD

                MessageBox.Show("¡Proveedor modificado correctamente!");

                CargarTabla(); // Recargamos para ver cambios
                Limpiar();     // Borramos textos y reseteamos la variable
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }

        }
        private void Limpiar()
        {
            txtCodigoProv.Text = "";
            txtRucProv.Text = "";
            txtNombreProv.Text = "";
            txtTelefonoProv.Text = "";
            txtDireccionProv.Text = "";
            idSeleccionado = 0; // ¡Muy importante volver a 0!
        }
    }
    }

