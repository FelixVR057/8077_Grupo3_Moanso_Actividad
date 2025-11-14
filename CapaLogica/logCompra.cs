using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCompra
    {
        #region Singleton
        private static readonly logCompra _instancia = new logCompra();
        public static logCompra Instancia
        {
            get { return _instancia; }
        }
        #endregion

        #region Métodos
        public List<entCompra> ListarCompra()
        {
            return datCompra.Instancia.ListarCompra();
        }

        public bool InsertarCompra(entCompra c)
        {
            if (c.Id_Prov <= 0 || c.Id_Mat <= 0)
                throw new Exception("Debe seleccionar un proveedor y un material.");
            if (c.Cant_DetComp <= 0 || c.PU_DetComp <= 0)
                throw new Exception("Cantidad y precio deben ser mayores que cero.");
            return datCompra.Instancia.InsertarCompra(c);
        }

        public bool EditarCompra(entCompra c)
        {
            if (c.Id_Comp <= 0)
                throw new Exception("Debe seleccionar una compra válida.");
            return datCompra.Instancia.EditarCompra(c);
        }

        public bool EliminarCompra(int idComp)
        {
            return datCompra.Instancia.EliminarCompra(idComp);
        }
        #endregion
    }
}
