using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProveedor
    {
        #region Singleton
        private static readonly logProveedor _instancia = new logProveedor();
        public static logProveedor Instancia
        {
            get { return _instancia; }
        }
        #endregion

        #region Métodos
        public List<entProveedor> ListarProveedor()
        {
            return datProveedor.Instancia.ListarProveedor();
        }

        public bool InsertarProveedor(entProveedor p)
        {
            if (string.IsNullOrEmpty(p.Nom_Prov) || string.IsNullOrEmpty(p.RUC_Prov))
                throw new Exception("Debe completar todos los campos del proveedor.");

            return datProveedor.Instancia.InsertarProveedor(p);
        }

        public bool EditarProveedor(entProveedor p)
        {
            if (p.Id_Prov <= 0)
                throw new Exception("Debe seleccionar un proveedor válido.");
            return datProveedor.Instancia.EditarProveedor(p);
        }

        public bool EliminarProveedor(int idProv)
        {
            return datProveedor.Instancia.EliminarProveedor(idProv);
        }
        #endregion
    }
}
