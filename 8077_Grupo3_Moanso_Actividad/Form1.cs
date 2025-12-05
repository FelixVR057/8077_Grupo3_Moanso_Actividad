using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
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
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            
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



        private void btnprueba_Click(object sender, EventArgs e)
        {
            
        }
    }
}

