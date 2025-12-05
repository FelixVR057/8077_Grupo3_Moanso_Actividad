
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaLogica
{
    public class CL_Cronograma
    {
        private CD_Cronograma objCapaDatos = new CD_Cronograma();

        public void Registrar(Cronograma obj)
        {

            if (obj.IdObra == 0)
            {
                throw new System.Exception("Debe seleccionar una Obra.");
            }
            if (string.IsNullOrEmpty(obj.Actividad))
            {
                throw new System.Exception("La actividad es obligatoria.");
            }

            objCapaDatos.RegistrarCronograma(obj);
        }

        public DataTable ListarCronograma()
        {
            return objCapaDatos.Listar();
        }
    }


}