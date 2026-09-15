using SistemaActividades.Datos;
using SistemaActividades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActividades.Negocio
{
    /// <summary>
    /// EVELYN PAMELA GUTIERREZ RUIZ 14/09/2026
    /// ESTA CLASE ES LA CAPA DE NEGOCIO QUE GESTIONA LAS ACTIVIDADES, PERMITIENDO AGREGAR NUEVAS ACTIVIDADES Y OBTENER TODAS LAS ACTIVIDADES EXISTENTES.
    /// </summary>
    public class ActividadNegocio
    {
        private ActividadDatos datos = new ActividadDatos();

        private int siguienteId = 1;

        public void Registrar(
            Actividad actividad,
            string costoTexto,
            string nombreResponsable,
            string telefono)
        {
            // Validar nombre
            if (string.IsNullOrWhiteSpace(actividad.Nombre))
            {
                throw new ArgumentException("El nombre es obligatorio.");
            }

            // Validar costo vacío
            if (string.IsNullOrWhiteSpace(costoTexto))
            {
                throw new ArgumentException("El costo es obligatorio.");
            }

            // Validar que costo sea número
            if (!decimal.TryParse(costoTexto, out decimal costo))
            {
                throw new ArgumentException("El costo debe ser un número.");
            }

            // Validar costo mayor a cero
            if (costo <= 0)
            {
                throw new ArgumentException("El costo debe ser mayor a cero.");
            }

            // Asignar costo
            actividad.costo = costo;

            // Validar responsable
            if (string.IsNullOrWhiteSpace(nombreResponsable))
            {
                throw new ArgumentException("El responsable es obligatorio.");
            }

            // Validar teléfono
            if (string.IsNullOrWhiteSpace(telefono))
            {
                throw new ArgumentException("El teléfono es obligatorio.");
            }

            // Crear responsable
            actividad.Responsable =
                new Responsable(nombreResponsable, telefono);

            // Validar información de la actividad
            if (!actividad.ValidarInformacion())
            {
                throw new ArgumentException(
                    "La información de la actividad no es válida.");
            }

            // Asignar ID
            actividad.Id = siguienteId;
            siguienteId++;

            // Guardar
            datos.AgregarActividad(actividad);
        }

        public List<Actividad> ObtenerActividades()
        {
            return datos.ObtenerTodas();
        }
    }
}


