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
        private datProveedor objDatos = new datProveedor();
        public void RegistrarProveedor(entProveedor obj)
        {
    
            if (string.IsNullOrEmpty(obj.Nombre) || string.IsNullOrEmpty(obj.RUC))
            {
                throw new Exception("El Nombre y el RUC son obligatorios.");
            }

            objDatos.Registrar(obj);
        }

       
        public void EditarProveedor(entProveedor obj)
        {
            if (obj.IdProveedor <= 0)
            {
                throw new Exception("No se ha seleccionado un proveedor válido.");
            }

            objDatos.Editar(obj);
        }

      
        public void EliminarProveedor(int idProveedor)
        {
            objDatos.Eliminar(idProveedor);
        }

        public DataTable ListarProveedor()
        {
            return objDatos.Listar();
        }
    }
}