using CapaEntidad;
using CapaLogica;
using System;
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
    public partial class MantenedorServicios : Form
    {
        public MantenedorServicios()
        {
            InitializeComponent();
        }

        private void MantenedorServicios_Load(object sender, EventArgs e)
        {
            CargarServicios();
            LimpiarControles();
        }
        // ======================= MÉTODOS AUXILIARES =======================

        private void LimpiarControles()
        {
            txtCodigoServicio.Text = "";
            txtNombreServicio.Text = "";
            txtPrecioBase.Text = "";
            txtTiempoEjecucion.Text = "";
            txtDescripcionDetallada.Text = "";
            // Si usas ComboBox para Categoría o ObraID, también límpialos o selecciona el valor predeterminado.
            txtNombreServicio.Focus();
        }


        private void CargarServicios()
        {
            try
            {
                logServicio logica = new logServicio();
                List<entServicio> lista = logica.ListarServicios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista: " + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entServicio nuevoServicio = new entServicio()
                {
                    NomServi = txtNombreServicio.Text,
                    PrecBase = Convert.ToDouble(txtPrecioBase.Text),
                    TiemEjecu = Convert.ToInt32(txtTiempoEjecucion.Text),
                    DescServi = txtDescripcionDetallada.Text,
                    ObraID = 1 
                };

                logServicio logica = new logServicio();
                bool exito = logica.RegistrarServicio(nuevoServicio);

                if (exito)
                {
                    MessageBox.Show("Servicio registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    CargarServicios(); 
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Advertencia de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de formato. Asegúrese de ingresar números válidos en Precio Base y Tiempo.", "Error de Conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Recolectar datos (El ID es CRUCIAL)
                entServicio servicioModificado = new entServicio()
                {
                    ServicioID = Convert.ToInt32(txtCodigoServicio.Text), // Debe venir de la fila seleccionada
                    NomServi = txtNombreServicio.Text,
                    PrecBase = Convert.ToDouble(txtPrecioBase.Text),
                    TiemEjecu = Convert.ToInt32(txtTiempoEjecucion.Text),
                    DescServi = txtDescripcionDetallada.Text,
                    ObraID = 1 // ⚠️ TEMPORAL
                };

                // 2. Llamar a la Capa Lógica
                logServicio logica = new logServicio();
                bool exito = logica.ModificarServicio(servicioModificado);

                // 3. Mostrar resultado
                if (exito)
                {
                    MessageBox.Show("Servicio modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    CargarServicios();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el servicio. Revise los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea inhabilitar/eliminar este servicio?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // 1. Obtener el ID del servicio a eliminar
                    int idSeleccionado = Convert.ToInt32(txtCodigoServicio.Text);

                    // 2. Llamar a la Capa Lógica
                    logServicio logica = new logServicio();
                    bool exito = logica.InhabilitarServicio(idSeleccionado);

                    // 3. Mostrar resultado
                    if (exito)
                    {
                        MessageBox.Show("Servicio inhabilitado/eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                        CargarServicios();
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inhabilitar: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvServicios.Rows[e.RowIndex];

                txtCodigoServicio.Text = fila.Cells["ServicioID"].Value.ToString();
                txtNombreServicio.Text = fila.Cells["NomServi"].Value.ToString();
                txtPrecioBase.Text = fila.Cells["PrecBase"].Value.ToString();
                txtTiempoEjecucion.Text = fila.Cells["TiemEjecu"].Value.ToString();
                txtDescripcionDetallada.Text = fila.Cells["DescServi"].Value.ToString();
            }
        }
    }
}
