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
    public partial class Login_Registro : Form
    {
        public Login_Registro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Ingresar frm = new Login_Ingresar();
            frm.Show();
            this.Close();
        }
    }
}
