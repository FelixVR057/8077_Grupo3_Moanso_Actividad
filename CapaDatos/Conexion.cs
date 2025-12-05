using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia => _instancia;

        private Conexion() { }

        public SqlConnection Conectar()
        {
            return new SqlConnection(

                "Data Source=DESKTOP-6LPI827\\NICOLAS; Initial Catalog=BD_DyR_Grupo_03_Prueba; Integrated Security=True;"

            );
        }
    }
}

