using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProveedor
    {
        #region Singleton
        private static readonly logProveedor _instancia = new logProveedor();
        public static logProveedor Instancia => _instancia;
        #endregion

        #region Métodos

        // 🔹 Listar todos los proveedores
        public DataTable ListarProveedor()
        {
            return datProveedor.Instancia.ListarProveedor();
        }

        // 🔹 Insertar un nuevo proveedor
        public bool InsertarProveedor(entProveedor p)
        {
            if (string.IsNullOrEmpty(p.NombreProveedor) || string.IsNullOrEmpty(p.RUC))
                throw new Exception("Debe completar todos los campos del proveedor.");

            return datProveedor.Instancia.InsertarProveedor(p);
        }

        // 🔹 Editar proveedor existente
        public bool EditarProveedor(entProveedor p)
        {
            if (p.IdProveedor <= 0)
                throw new Exception("Debe seleccionar un proveedor válido.");

            return datProveedor.Instancia.EditarProveedor(p);
        }

        // 🔹 Eliminar (o deshabilitar) proveedor
        public bool EliminarProveedor(int idProveedor)
        {
            return datProveedor.Instancia.EliminarProveedor(idProveedor);
        }

        #endregion
    }
}
