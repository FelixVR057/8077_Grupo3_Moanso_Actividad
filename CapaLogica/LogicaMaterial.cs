using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaLogica
{
    public class LogicaMaterial
    {
        private static readonly LogicaMaterial _instancia = new LogicaMaterial();
        public static LogicaMaterial Instancia => _instancia;

        public List<CE_Material> ListarMateriales()
        {
            return DaoMaterial.Instancia.ListarMateriales();
        }

        public void AgregarMaterial(CE_Material mat)
        {
            DaoMaterial.Instancia.InsertarMaterial(mat);
        }

    }
}
