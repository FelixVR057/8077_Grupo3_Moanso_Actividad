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
        #region Singleton
        public class datProveedor
        {
            // Pega aquí TU cadena de conexión correcta (con punto . o SQLEXPRESS)
            private string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=BD_DyR_Grupo_03;Integrated Security=True";

            public void Registrar(entProveedor obj)
            {
                using (SqlConnection oConexion = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("spRegistrarProveedor", oConexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("@RUC", obj.RUC);
                    cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("@FechaRegistro", obj.FechaRegistro);

                    try
                    {
                        oConexion.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error BD: " + ex.Message);
                    }
                }
            }

        // Asegúrate de tener: using System.Data; y using System.Collections.Generic;

        public DataTable Listar()
        {
            using (SqlConnection oConexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("spListarProveedores", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    oConexion.Open();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar: " + ex.Message);
                }
            }
        }


        #endregion

        #region Métodos

        // Listar todos los proveedores
        public List<entProveedor> ListarProveedor()
            {
                SqlCommand cmd = null;
                List<entProveedor> lista = new List<entProveedor>();
                try
                {
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    cmd = new SqlCommand("spListarProveedor", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        entProveedor p = new entProveedor();
                        p.IdProveedor = Convert.ToInt32(dr["Id_Prov"]);
                        p.Nombre = dr["Nom_Prov"].ToString();
                        p.RUC= dr["RUC_Prov"].ToString();
                        lista.Add(p);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cmd.Connection.Close();
                }
                return lista;
            }

            // Insertar proveedor
            public bool InsertarProveedor(entProveedor p)
            {
                SqlCommand cmd = null;
                bool inserta = false;
                try
                {
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    cmd = new SqlCommand("spInsertarProveedor", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nom_Prov", p.Nombre);
                    cmd.Parameters.AddWithValue("@RUC_Prov", p.RUC);
                    cn.Open();

                    int i = cmd.ExecuteNonQuery();
                    inserta = (i > 0);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cmd.Connection.Close();
                }
                return inserta;
            }

            // Editar proveedor
            public bool EditarProveedor(entProveedor p)
            {
                SqlCommand cmd = null;
                bool edita = false;
                try
                {
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    cmd = new SqlCommand("spEditarProveedor", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Prov", p.IdProveedor);
                    cmd.Parameters.AddWithValue("@Nom_Prov", p.Nombre);
                    cmd.Parameters.AddWithValue("@RUC_Prov", p.RUC);
                    cn.Open();

                    int i = cmd.ExecuteNonQuery();
                    edita = (i > 0);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cmd.Connection.Close();
                }
                return edita;
            }

            // Eliminar proveedor
            public bool EliminarProveedor(int idProv)
            {
                SqlCommand cmd = null;
                bool elimina = false;
                try
                {
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    cmd = new SqlCommand("spEliminarProveedor", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Prov", idProv);
                    cn.Open();

                    int i = cmd.ExecuteNonQuery();
                    elimina = (i > 0);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cmd.Connection.Close();
                }
                return elimina;
            }

        #endregion
        // Método para EDITAR
        public void Editar(entProveedor obj)
        {
            using (SqlConnection oConexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("spEditarProveedor", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdProveedor", obj.IdProveedor);
                cmd.Parameters.AddWithValue("@Codigo", obj.Codigo);
                cmd.Parameters.AddWithValue("@RUC", obj.RUC);
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al editar: " + ex.Message);
                }
            }
        }

        // Método para ELIMINAR
        public void Eliminar(int id)
        {
            using (SqlConnection oConexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("spEliminarProveedor", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProveedor", id);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar: " + ex.Message);
                }
            }
        }

    } 

} 
    
