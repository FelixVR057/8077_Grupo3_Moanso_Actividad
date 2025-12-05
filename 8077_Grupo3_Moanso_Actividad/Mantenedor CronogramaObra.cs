using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    


namespace _8077_Grupo3_Moanso_Actividad
{
    public partial class Mantenedor_CronogramaObra : Form
    {
        public Mantenedor_CronogramaObra()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoCrono_Click(object sender, EventArgs e)
        {
            try
            {
                Cronograma nuevoCrono = new Cronograma();

                // IMPORTANTE: Convertimos el valor seleccionado a int
                nuevoCrono.IdObra = Convert.ToInt32(cboObra.SelectedValue);
                nuevoCrono.Actividad = txtActividad.Text;
                nuevoCrono.Responsable = txtResponsable.Text;
                nuevoCrono.FechaInicio = dtpFechaInicio.Value;
                nuevoCrono.FechaFin = dtpFechaFin.Value;

                CL_Cronograma logica = new CL_Cronograma();
                logica.Registrar(nuevoCrono);

                MessageBox.Show("Registrado correctamente");
                MostrarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Mantenedor_CronogramaObra_Load(object sender, EventArgs e)
        {
            CargarObras();
            MostrarTabla();
        }

        private void MostrarTabla()
        {
            CL_Cronograma logica = new CL_Cronograma();
            try
            {
                // Asumiendo que tu DataGridView se llama dgvCronograma
                dgvCronograma.DataSource = logica.ListarCronograma();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }

        // Método para llenar el combo (puedes poner esto en CapaDatos también si quieres ser estricto)
        // Método para llenar el combo
        private void CargarObras()
        {
            // 1. Cadena de conexión (Asegúrate que sea la misma que usas en CapaDatos)
            string cadena = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=BD_DyR_Grupo_03;Integrated Security=True";

            using (SqlConnection cn = new SqlConnection(cadena))
            {
                try
                {
                    cn.Open();
                    // 2. Traemos el ID y el Nombre de la obra
                    SqlCommand cmd = new SqlCommand("SELECT ObraID, NomObra FROM Obra", cn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 3. Asignamos los datos al ComboBox
                    // IMPORTANTE: Asegúrate de que tu combo se llame 'cboObra' o cámbiale el nombre aquí
                    cboObra.DataSource = dt;
                    cboObra.DisplayMember = "NomObra"; // Lo que ves en la lista
                    cboObra.ValueMember = "ObraID";    // El valor oculto (ID)

                    // Esto es para que inicie sin nada seleccionado (opcional)
                    cboObra.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar obras: " + ex.Message);
                }
            }
        }
        // Llama a esto cuando carga el form
        private void FormCronograma_Load(object sender, EventArgs e)
        {
            CargarObras();
        }
    }
}

