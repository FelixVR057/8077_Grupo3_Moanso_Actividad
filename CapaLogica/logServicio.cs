using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logServicio
    {
        // Instancia la Capa de Datos para poder llamar a sus métodos SQL
        private datServicio datos = new datServicio();

        // ======================= MÉTODO REGISTRAR =======================
        public bool RegistrarServicio(entServicio servicio)
        {
            // 1. Validaciones/Reglas de Negocio
            if (string.IsNullOrEmpty(servicio.NomServi))
            {
                // Si falla la regla, lanzamos una excepción específica (ArgumentException)
                throw new ArgumentException("El nombre del servicio es obligatorio.");
            }
            if (servicio.PrecBase <= 0)
            {
                throw new ArgumentException("El Precio Base debe ser mayor a cero.");
            }

            // 2. Si pasa las validaciones, llama a la Capa de Datos para ejecutar el INSERT
            try
            {
                return datos.InsertarServicio(servicio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la Lógica (RegistrarServicio): " + ex.Message);
            }
        }

        // ======================= MÉTODO MODIFICAR =======================
        public bool ModificarServicio(entServicio servicio)
        {
            // Validación de Negocio para Modificar
            if (servicio.ServicioID <= 0)
            {
                throw new ArgumentException("Debe seleccionar un servicio válido para modificar (ID requerido).");
            }
            if (string.IsNullOrEmpty(servicio.NomServi))
            {
                throw new ArgumentException("El nombre del servicio no puede quedar vacío.");
            }

            try
            {
                return datos.ActualizarServicio(servicio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la Lógica (ModificarServicio): " + ex.Message);
            }
        }

        // ======================= MÉTODO LISTAR =======================
        public List<entServicio> ListarServicios()
        {
            // Generalmente, no hay reglas de negocio para solo listar.
            return datos.ListarServicios();
        }

        // ======================= MÉTODO INHABILITAR =======================
        public bool InhabilitarServicio(int idServicio)
        {
            if (idServicio <= 0)
            {
                throw new ArgumentException("Debe seleccionar un servicio válido para inhabilitar.");
            }

            try
            {
                return datos.InhabilitarServicio(idServicio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la Lógica (InhabilitarServicio): " + ex.Message);
            }
        }
    }
}

