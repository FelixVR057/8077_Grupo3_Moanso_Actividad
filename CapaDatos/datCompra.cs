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
        #region Singleton
        private static readonly datCompra _instancia = new datCompra();
        public static datCompra Instancia
        {
            get { return _instancia; }
        }
        #endregion

        #region Métodos

        // Listar todas las compras
        public List<entCompra> ListarCompra()
        {
            SqlCommand cmd = null;
            List<entCompra> lista = new List<entCompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCompra c = new entCompra();
                    c.Id_Comp = Convert.ToInt32(dr["Id_Comp"]);
                    c.Id_Us = Convert.ToInt32(dr["Id_Us"]);
                    c.Id_Prov = Convert.ToInt32(dr["Id_Prov"]);
                    c.Id_Mat = Convert.ToInt32(dr["Id_Mat"]);
                    c.Cant_DetComp = Convert.ToInt32(dr["Cant_DetComp"]);
                    c.PU_DetComp = Convert.ToDecimal(dr["PU_DetComp"]);
                    c.Tot_Comp = Convert.ToDecimal(dr["Tot_Comp"]);
                    c.Fec_Comp = Convert.ToDateTime(dr["Fec_Comp"]);
                    c.Nom_Prov = dr["Nom_Prov"].ToString();
                    c.Nom_Mat = dr["Nom_Mat"].ToString();
                    lista.Add(c);
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

        // Insertar compra (con detalle)
        public bool InsertarCompra(entCompra c)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Us", c.Id_Us);
                cmd.Parameters.AddWithValue("@Id_Prov", c.Id_Prov);
                cmd.Parameters.AddWithValue("@Id_Mat", c.Id_Mat);
                cmd.Parameters.AddWithValue("@Cant_DetComp", c.Cant_DetComp);
                cmd.Parameters.AddWithValue("@PU_DetComp", c.PU_DetComp);
                cmd.Parameters.AddWithValue("@Fec_Comp", c.Fec_Comp);
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

        // Modificar compra (ej. cambiar cantidad o precio)
        public bool EditarCompra(entCompra c)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Comp", c.Id_Comp);
                cmd.Parameters.AddWithValue("@Cant_DetComp", c.Cant_DetComp);
                cmd.Parameters.AddWithValue("@PU_DetComp", c.PU_DetComp);
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

        // Eliminar compra
        public bool EliminarCompra(int idComp)
        {
            SqlCommand cmd = null;
            bool elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Comp", idComp);
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

