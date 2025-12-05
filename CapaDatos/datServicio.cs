using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datServicio
    {
        private Conexion oConexion = Conexion.Instancia;

        // ======================= 2.2. MÉTODO INSERTAR (REGISTRAR) =======================
        public bool InsertarServicio(entServicio servicio)
        {
            string sql = "INSERT INTO Servicio (NomServi, PrecBase, TiemEjecu, DescServi, ObraID) VALUES (@nombre, @precio, @tiempo, @descrip, @obra)";
            int filasAfectadas = 0;

            // 1. Obtener la conexión (Usa tu método Conectar())
            SqlConnection conexion = oConexion.Conectar();

            try
            {
                conexion.Open(); // 2. Abrir la conexión

                SqlCommand cmd = new SqlCommand(sql, conexion);
                // Usamos parámetros (es más seguro)
                cmd.Parameters.AddWithValue("@nombre", servicio.NomServi);
                cmd.Parameters.AddWithValue("@precio", servicio.PrecBase);
                cmd.Parameters.AddWithValue("@tiempo", servicio.TiemEjecu);
                cmd.Parameters.AddWithValue("@descrip", servicio.DescServi);
                cmd.Parameters.AddWithValue("@obra", servicio.ObraID);

                filasAfectadas = cmd.ExecuteNonQuery(); // Ejecuta el INSERT
            }
            catch (Exception ex)
            {
                throw new Exception("Error en CapaDatos (InsertarServicio): " + ex.Message);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open) conexion.Close(); // 3. Cerrar conexión
            }
            return filasAfectadas > 0; // True si se insertó al menos una fila
        }

        // ======================= 2.3. MÉTODO LISTAR (READ) =======================
        public List<entServicio> ListarServicios()
        {
            List<entServicio> lista = new List<entServicio>();
            string sql = "SELECT ServicioID, NomServi, PrecBase, TiemEjecu, DescServi, ObraID FROM Servicio";
            SqlConnection conexion = oConexion.Conectar();

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(sql, conexion);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read()) // Lee cada registro
                {
                    lista.Add(new entServicio()
                    {
                        // Mapeo de SqlDataReader a entServicio
                        ServicioID = Convert.ToInt32(dr["ServicioID"]),
                        NomServi = dr["NomServi"].ToString(),
                        PrecBase = Convert.ToDouble(dr["PrecBase"]),
                        TiemEjecu = Convert.ToInt32(dr["TiemEjecu"]),
                        DescServi = dr["DescServi"].ToString(),
                        ObraID = Convert.ToInt32(dr["ObraID"])
                    });
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en CapaDatos (ListarServicios): " + ex.Message);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open) conexion.Close();
            }
            return lista;
        }

        // ======================= 2.4. MÉTODO ACTUALIZAR (MODIFICAR) =======================
        public bool ActualizarServicio(entServicio servicio)
        {
            // El UPDATE es casi idéntico al INSERT, pero incluye la cláusula WHERE
            string sql = "UPDATE Servicio SET NomServi = @nombre, PrecBase = @precio, TiemEjecu = @tiempo, DescServi = @descrip, ObraID = @obra WHERE ServicioID = @id";
            int filasAfectadas = 0;
            SqlConnection conexion = oConexion.Conectar();

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@nombre", servicio.NomServi);
                cmd.Parameters.AddWithValue("@precio", servicio.PrecBase);
                cmd.Parameters.AddWithValue("@tiempo", servicio.TiemEjecu);
                cmd.Parameters.AddWithValue("@descrip", servicio.DescServi);
                cmd.Parameters.AddWithValue("@obra", servicio.ObraID);
                cmd.Parameters.AddWithValue("@id", servicio.ServicioID); // ¡Clave!

                filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en CapaDatos (ActualizarServicio): " + ex.Message);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open) conexion.Close();
            }
            return filasAfectadas > 0;
        }

        // ======================= 2.5. MÉTODO INHABILITAR (ELIMINAR) =======================
        public bool InhabilitarServicio(int idServicio)
        {
            // DELETE (Eliminación física)
            string sql = "DELETE FROM Servicio WHERE ServicioID = @id";
            int filasAfectadas = 0;
            SqlConnection conexion = oConexion.Conectar();

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@id", idServicio);
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Este error puede ocurrir si el servicio está referenciado por otra tabla (FK)
                throw new Exception("Error en CapaDatos (InhabilitarServicio): " + ex.Message);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open) conexion.Close();
            }
            return filasAfectadas > 0;
        }
    }
}

