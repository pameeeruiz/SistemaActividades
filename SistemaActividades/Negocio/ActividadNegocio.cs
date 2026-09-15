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

        public string Registrar(
            Actividad actividad,
            string costoTexto,
            string nombreResponsable,
            string telefono)
        {
            if (string.IsNullOrWhiteSpace(actividad.Nombre))
            {
                return "Nombre";
            }

            if (string.IsNullOrWhiteSpace(costoTexto))
            {
                return "Costo";
            }

            if (!decimal.TryParse(costoTexto, out decimal costo))
            {
                return "Costo";
            }

            if (costo <= 0)
            {
                return "Costo";
            }

            if (string.IsNullOrWhiteSpace(nombreResponsable))
            {
                return "Responsable";
            }

            if (string.IsNullOrWhiteSpace(telefono))
            {
                return "Telefono";
            }

            actividad.costo = costo;

            actividad.Responsable =
                new Responsable(nombreResponsable, telefono);

            actividad.Id = siguienteId;
            siguienteId++;

            datos.AgregarActividad(actividad);

            return "";
        }

        public List<Actividad> ObtenerActividades()
        {
            return datos.ObtenerTodas();
        }
    }
}


