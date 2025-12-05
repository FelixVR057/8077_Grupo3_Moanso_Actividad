using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cronograma
    {
        public int IdCronograma { get; set; }
        public int IdObra { get; set; }        // CAMBIO: Ahora es int para guardar el ID
        public string Actividad { get; set; }
        public string Responsable { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
