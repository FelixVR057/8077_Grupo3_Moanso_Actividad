using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCompra
    {
        public int IdOrdenCompra { get; set; }
        public int IdProveedor { get; set; }
        public string RUC { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        // Propiedades adicionales (para mostrar datos combinados)
        public string NombreProveedor { get; set; }
    }
}
