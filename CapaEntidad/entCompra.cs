using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    // Clase principal para transportar la información de la Compra y su detalle
    public class entCompra
    {
        // =================================================================
        // PROPIEDADES DE LA ORDEN DE COMPRA (TABLA Ordencompra)
        // =================================================================
        public int Id_Comp { get; set; }        // ID de la Orden de Compra (PK)
        public int Id_Us { get; set; }          // ID del Usuario que realiza la compra (FK)
        public int Id_Prov { get; set; }        // ID del Proveedor (FK)
        public DateTime Fec_Comp { get; set; }  // Fecha de la Compra

        // Propiedad agregada para resolver el último error de compilación
        public decimal Tot_Comp { get; set; }   // Total de la Compra (puede venir de la BD)

        // -----------------------------------------------------------------
        // PROPIEDADES AUXILIARES / DE VISUALIZACIÓN (De JOINS en CapaDatos)
        // -----------------------------------------------------------------
        public string Nom_Prov { get; set; }    // Nombre del Proveedor

        // =================================================================
        // PROPIEDADES DEL DETALLE DE COMPRA (TABLA Detallecompra)
        // =================================================================
        public int Id_Mat { get; set; }         // ID del Material comprado (FK)
        public string Nom_Mat { get; set; }     // Nombre o Descripción del Material
        public int Cant_DetComp { get; set; }   // Cantidad comprada
        public decimal PU_DetComp { get; set; } // Precio Unitario (Usamos decimal)

        // Propiedad calculada: siempre es útil para la UI
        public decimal Total_DetComp
        {
            get { return Cant_DetComp * PU_DetComp; }
        }
    }
}