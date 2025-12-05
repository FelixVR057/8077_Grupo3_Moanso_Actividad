using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datProveedor
    {
        private static readonly datProveedor _instancia = new datProveedor();
        public static datProveedor Instancia => _instancia;

        // 🔹 LISTAR PROVEEDORES
        public DataTable ListarProveedor()
        {
            SqlCommand cmd = null;
            DataTable dt = new DataTable();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SELECT IdProveedor, NombreProveedor, RUC, Estado FROM Proveedor", cn);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar proveedores: " + ex.Message);
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }

            return dt;
        }

        // 🔹 INSERTAR PROVEEDOR
        public bool InsertarProveedor(entProveedor p)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("INSERT INTO Proveedor (NombreProveedor, RUC, Estado) VALUES (@NombreProveedor, @RUC, @Estado)", cn);
                cmd.Parameters.AddWithValue("@NombreProveedor", p.NombreProveedor);
                cmd.Parameters.AddWithValue("@RUC", p.RUC);
                cmd.Parameters.AddWithValue("@Estado", p.Estado);

                cn.Open();
                int filas = cmd.ExecuteNonQuery();
                ok = filas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar proveedor: " + ex.Message);
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }

            return ok;
        }

        // 🔹 EDITAR PROVEEDOR
        public bool EditarProveedor(entProveedor p)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("UPDATE Proveedor SET NombreProveedor=@NombreProveedor, RUC=@RUC, Estado=@Estado WHERE IdProveedor=@IdProveedor", cn);
                cmd.Parameters.AddWithValue("@IdProveedor", p.IdProveedor);
                cmd.Parameters.AddWithValue("@NombreProveedor", p.NombreProveedor);
                cmd.Parameters.AddWithValue("@RUC", p.RUC);
                cmd.Parameters.AddWithValue("@Estado", p.Estado);

                cn.Open();
                int filas = cmd.ExecuteNonQuery();
                ok = filas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar proveedor: " + ex.Message);
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }

            return ok;
        }

        // 🔹 ELIMINAR (DESHABILITAR) PROVEEDOR
        public bool EliminarProveedor(int idProveedor)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                // ⚠️ En lugar de borrar, cambia el estado a 'Inactivo'
                cmd = new SqlCommand("UPDATE Proveedor SET Estado='Inactivo' WHERE IdProveedor=@IdProveedor", cn);
                cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);

                cn.Open();
                int filas = cmd.ExecuteNonQuery();
                ok = filas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar proveedor: " + ex.Message);
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }

            return ok;
        }
    }
}