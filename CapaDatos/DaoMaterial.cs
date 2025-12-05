using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class DaoMaterial
    {
        private static readonly DaoMaterial _instancia = new DaoMaterial();
        public static DaoMaterial Instancia => _instancia;

        public List<CE_Material> ListarMateriales()
        {
            List<CE_Material> lista = new List<CE_Material>();
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ListarMateriales", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CE_Material m = new CE_Material
                    {
                        MaterialID = Convert.ToInt32(dr["MaterialID"]),
                        CodMaterial = dr["CodMaterial"].ToString(),
                        DescrMaterial = dr["DescrMaterial"].ToString(),
                        UniMedida = dr["UniMedida"].ToString(),
                        StockMat = Convert.ToInt32(dr["StockMat"])
                    };

                    lista.Add(m);
                }
            }
            finally
            {
                cmd.Connection.Close();
            }

            return lista;
        }

        public void InsertarMaterial(CE_Material mat)
        {
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("sp_InsertarMaterial", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CodMaterial", mat.CodMaterial);
                    cmd.Parameters.AddWithValue("@DescrMaterial", mat.DescrMaterial);
                    cmd.Parameters.AddWithValue("@UniMedida", mat.UniMedida);
                    cmd.Parameters.AddWithValue("@StockMat", mat.StockMat);
                    // Si necesitas, también los IDs de Ordencompra y NotaIngreso
                    // cmd.Parameters.AddWithValue("@OrdencompraID", mat.OrdencompraID);
                    // cmd.Parameters.AddWithValue("@NotaingresomaterialID", mat.NotaingresomaterialID);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection.State == System.Data.ConnectionState.Open)
                    cmd.Connection.Close();
            }
        }

    }
}
