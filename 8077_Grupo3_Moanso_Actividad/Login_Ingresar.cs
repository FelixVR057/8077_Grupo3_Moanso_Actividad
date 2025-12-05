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
    public partial class Login_Ingresar : Form
    {
        public Login_Ingresar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            Login_Registro frm = new Login_Registro();
            frm.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MantenedorMaterial frm = new MantenedorMaterial();
            frm.Show();
            this.Hide();
        }
    }
}
