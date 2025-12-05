using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CD_Material
    {
        private static readonly CD_Material _instancia = new CD_Material();
        public static CD_Material Instancia => _instancia;

        public List<CE_Material> ListarMateriales()
        {
            List<CE_Material> lista = new List<CE_Material>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT MaterialID, CodMaterial, DescrMaterial, UniMedida, StockMat FROM Material",
                    cn
                );

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new CE_Material()
                    {
                        MaterialID = Convert.ToInt32(dr["MaterialID"]),
                        CodMaterial = dr["CodMaterial"].ToString(),
                        DescrMaterial = dr["DescrMaterial"].ToString(),
                        UniMedida = dr["UniMedida"].ToString(),
                        StockMat = Convert.ToInt32(dr["StockMat"])
                    });
                }
            }

            return lista;
        }


        public bool InsertarMaterial(CE_Material material)
        {
            bool resultado = false;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarMaterial", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodMaterial", material.CodMaterial);
                cmd.Parameters.AddWithValue("@DescrMaterial", material.DescrMaterial);
                cmd.Parameters.AddWithValue("@UniMedida", material.UniMedida);
                cmd.Parameters.AddWithValue("@StockMat", material.StockMat);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) resultado = true;
            }
            return resultado;
        }

    }
}
