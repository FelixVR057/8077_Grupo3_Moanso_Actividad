using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Cronograma
    {
        // Asegúrate de poner aquí tu cadena de conexión correcta
        private string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=BD_DyR_Grupo_03;Integrated Security=True";

        public void RegistrarCronograma(Cronograma obj)
        {
            using (SqlConnection oConexion = new SqlConnection(cadenaConexion))
            {
                // Usamos TU procedimiento almacenado
                SqlCommand cmd = new SqlCommand("spRegistrarCronograma", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros exactos como están en tu SQL
                cmd.Parameters.AddWithValue("@IdObra", obj.IdObra);
                cmd.Parameters.AddWithValue("@Actividad", obj.Actividad);
                cmd.Parameters.AddWithValue("@Responsable", obj.Responsable);
                cmd.Parameters.AddWithValue("@FechaInicio", obj.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", obj.FechaFin);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en BD: " + ex.Message);
                }
            }
        }
        // Asegúrate de tener: using System.Data; y using System.Data.SqlClient;

        public DataTable Listar()
        {
            // Usa la misma cadena de conexión que ya te funcionó
            using (SqlConnection oConexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("spListarCronograma", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    oConexion.Open();
                    da.Fill(dt); // Llena la tabla con los datos de la BD
                    return dt;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar: " + ex.Message);
                }
            }
        }

    }
}