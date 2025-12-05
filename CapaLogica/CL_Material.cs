using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_Material
    {
        private static readonly CL_Material _instancia = new CL_Material();
        public static CL_Material Instancia => _instancia;

        public List<CE_Material> ObtenerMateriales()
        {
            return CD_Material.Instancia.ListarMateriales();
        }

    }
}
