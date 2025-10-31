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
    public class datProveedor
    {
        #region Singleton
        private static readonly datProveedor _instancia = new datProveedor();
        public static datProveedor Instancia
        {
            get { return _instancia; }
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
                    p.Id_Prov = Convert.ToInt32(dr["Id_Prov"]);
                    p.Nom_Prov = dr["Nom_Prov"].ToString();
                    p.RUC_Prov = dr["RUC_Prov"].ToString();
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
                cmd.Parameters.AddWithValue("@Nom_Prov", p.Nom_Prov);
                cmd.Parameters.AddWithValue("@RUC_Prov", p.RUC_Prov);
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
                cmd.Parameters.AddWithValue("@Id_Prov", p.Id_Prov);
                cmd.Parameters.AddWithValue("@Nom_Prov", p.Nom_Prov);
                cmd.Parameters.AddWithValue("@RUC_Prov", p.RUC_Prov);
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
    }
}
