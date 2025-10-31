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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            try
            {
                DataTable dt = txtProveedor.Instancia.ListarProveedor();
                txtProveedor.DataSource = dt;
                txtProveedor.DisplayMember = "NombreProveedor";
                txtProveedor.ValueMember = "IdProveedor";
                txtProveedor.SelectedIndex = -1; // Ninguno seleccionado al inicio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

    }
}

