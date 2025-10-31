using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datCompra
    {
        // Patrón Singleton
        private static readonly datCompra _instancia = new datCompra();
        public static datCompra Instancia => _instancia;

        // 🔹 Método para registrar compra
        public bool RegistrarCompra(entCompra c)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarOrdenCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdProveedor", c.IdProveedor);
                cmd.Parameters.AddWithValue("@RUC", c.RUC);
                cmd.Parameters.AddWithValue("@Producto", c.Producto);
                cmd.Parameters.AddWithValue("@Cantidad", c.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioUnitario", c.PrecioUnitario);
                cmd.Parameters.AddWithValue("@Fecha", c.Fecha);
                cmd.Parameters.AddWithValue("@Estado", c.Estado);

                cn.Open();
                int filas = cmd.ExecuteNonQuery();
                ok = filas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar compra: " + ex.Message);
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }

            return ok;
        }

        // 🔹 Método para listar compras
        public DataTable ListarCompras()
        {
            SqlCommand cmd = null;
            DataTable dt = new DataTable();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarOrdenCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar compras: " + ex.Message);
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }

            return dt;
        }
    }
}
