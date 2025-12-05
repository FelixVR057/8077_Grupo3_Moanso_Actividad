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
    public partial class PanelInicio : Form
    {
        public PanelInicio()
        {
            InitializeComponent();
            Diseño();
        }

        private void PanelInicio_Load(object sender, EventArgs e)
        {

        }

        private void Diseño()
        {
            subpanelRegistro.Visible = false;
            subpanelReq.Visible = false;
            subpanelMov.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (subpanelRegistro.Visible)
                subpanelRegistro.Visible = false;
            if (subpanelReq.Visible)
                subpanelReq.Visible = false;
            if (subpanelMov.Visible)
                subpanelMov.Visible = false;

        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                OcultarSubMenu(); // Oculta los demás
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false; // Si ya estaba visible, se oculta
            }
        }

        private void btnMenuRegistros_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(subpanelRegistro);
        }

        private void btnMenuRequerimientos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(subpanelReq);
        }

        private void btnMenuMovimientos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(subpanelMov);
        }

        private Form formularioActivo = null; // Form actual mostrado en el panel

        private void AbrirFormEnPanel(Form formHijo)
        {
            // Cierra el form que ya estaba abierto
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formHijo;

            formHijo.TopLevel = false;      // Esto hace que el form sea hijo del panel
            formHijo.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            formHijo.Dock = DockStyle.Fill; // Se ajusta al tamaño del panel
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }


        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new MantenedorProveedor());
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new MantenedorMaterial());
        }

        private void btnObra_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Mantenedor_Obra());
        }

        private void btnCronograma_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Mantenedor_CronogramaObra());
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new MantenedorServicios());
        }

        private void btnReMat_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Requerimiento_Material());
        }

        private void btnIngresoMat_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new NotaIngresoMaterial());
        }

        private void btnSalidaMat_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new NotaSalidaMaterial());
        }

        private void btnReObra_Click(object sender, EventArgs e)
        {
            
        }
    }
}
