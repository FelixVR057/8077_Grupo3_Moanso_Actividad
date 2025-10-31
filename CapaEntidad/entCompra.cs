using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCompra
    {
        public int Id_Comp { get; set; }
        public int Id_Us { get; set; }       // Usuario que registra la compra
        public int Id_Prov { get; set; }  
        public int Id_Mat { get; set; }  
        public int Cant_DetComp { get; set; }
        public decimal PU_DetComp { get; set; }
        public decimal Tot_Comp { get; set; }
        public DateTime Fec_Comp { get; set; }

        // Propiedades adicionales
        public string Nom_Prov { get; set; } 
        public string Nom_Mat { get; set; } 
    }
}
