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
    public partial class MantenedorMaterial : Form
    {
        public MantenedorMaterial()
        {
            InitializeComponent();
            CargarMateriales();
            this.Load += MantenedorMaterial_Load;
        }

        private void MantenedorMaterial_Load(object sender, EventArgs e)
        {
            // Deshabilitar campos de entrada
            txtCodMat.Enabled = false;
            txtDescMaterial.Enabled = false;
            txtStock.Enabled = false;
            cbUndMed.Enabled = false;

            // Deshabilitar botón Guardar
            btnGuardarMat.Enabled = false;

            // Habilitar solo botón Nuevo
            btnNuevoMat.Enabled = true;

            // Opcional: cargar los datos en el DataGridView
            CargarMateriales();

            // Opcional: precargar ComboBox
            cbUndMed.Items.Clear();
            cbUndMed.Items.AddRange(new string[] { "Kg", "m", "l", "Unidad" });
        }


        private void CargarMateriales()
        {
            dgvMantenedorMat.DataSource = CL_Material.Instancia.ObtenerMateriales();

            // Encabezados más amigables
            dgvMantenedorMat.Columns["MaterialID"].HeaderText = "ID";
            dgvMantenedorMat.Columns["CodMaterial"].HeaderText = "Código";
            dgvMantenedorMat.Columns["DescrMaterial"].HeaderText = "Descripción";
            dgvMantenedorMat.Columns["UniMedida"].HeaderText = "Unidad";
            dgvMantenedorMat.Columns["StockMat"].HeaderText = "Stock";

            // Ajustes opcionales
            dgvMantenedorMat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMantenedorMat.DataSource = LogicaMaterial.Instancia.ListarMateriales();
        }

        

        private void dgvMantenedorMat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvMantenedorMat.Rows[e.RowIndex];

                txtCodMat.Text = fila.Cells["CodMaterial"].Value.ToString();
                txtDescMaterial.Text = fila.Cells["DescrMaterial"].Value.ToString();
                cbUndMed.Text = fila.Cells["UniMedida"].Value.ToString();
                txtStock.Text = fila.Cells["StockMat"].Value.ToString();
            }
        }

        private void btnNuevoMat_Click(object sender, EventArgs e)
        {
            txtCodMat.Enabled = true;
            txtDescMaterial.Enabled = true;
            txtStock.Enabled = true;

            cbUndMed.Enabled = true;

            // Limpiar campos
            txtCodMat.Text = "";
            txtDescMaterial.Text = "";
            txtStock.Text = "";

            cbUndMed.SelectedIndex = -1;

            // Habilitar botón Guardar
            btnGuardarMat.Enabled = true;

            // Opcional: deshabilitar el botón Nuevo mientras se ingresa
            btnNuevoMat.Enabled = false;
        }

        private void btnGuardarMat_Click(object sender, EventArgs e)
        {
            try
            {
                CE_Material nuevoMaterial = new CE_Material()
                {
                    CodMaterial = txtCodMat.Text,
                    DescrMaterial = txtDescMaterial.Text,
                    UniMedida = cbUndMed.SelectedItem.ToString(),
                    StockMat = Convert.ToInt32(txtStock.Text)
                };

                // Llamar a tu lógica para insertar en BD
                LogicaMaterial.Instancia.AgregarMaterial(nuevoMaterial);

                MessageBox.Show("Material agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar DataGridView
                CargarMateriales();

                // Limpiar y deshabilitar campos
                txtCodMat.Text = "";
                txtDescMaterial.Text = "";
                txtStock.Text = "";

                cbUndMed.SelectedIndex = -1;

                txtCodMat.Enabled = false;
                txtDescMaterial.Enabled = false;
                txtStock.Enabled = false;

                cbUndMed.Enabled = false;

                btnGuardarMat.Enabled = false;
                btnNuevoMat.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el material: " + ex.Message);
            }

        }
    }
}
