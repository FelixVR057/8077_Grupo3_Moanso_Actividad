using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datUsuario
    {
        private static readonly datUsuario _instancia = new datUsuario();
        public static datUsuario Instancia { get { return _instancia; } }

        // Método para validar login
        public bool ValidarLogin(string nombreUsuario, string contrasena)
        {
            bool valido = false;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string query = "SELECT COUNT(1) FROM Usuario WHERE NombreUsuario = @NombreUsuario AND Contrasena = @Contrasena";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    cn.Open();
                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                    if (resultado > 0)
                        valido = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return valido;
        }

    }
}
