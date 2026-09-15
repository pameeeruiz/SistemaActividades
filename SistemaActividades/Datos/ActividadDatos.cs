using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaActividades.Modelo;

namespace SistemaActividades.Datos
{
    /// <summary>
    /// EVELYN PAMELA GUTIERREZ RUIZ 14/09/2026
    /// ESTA CLASE ES RESPONSABLE DE GESTIONAR LOS DATOS DE LAS ACTIVIDADES, PERMITIENDO AGREGAR Y OBTENER ACTIVIDADES.
    /// </summary>
    public class ActividadDatos
    {
        // Lista para almacenar las actividades
        private List<Actividad> actividades = new List<Actividad>();

        // Método para agregar una actividad a la lista
        public void AgregarActividad(Actividad actividad)
        {
            actividades.Add(actividad);
        }

        // Método para obtener todas las actividades
        public List<Actividad> ObtenerTodas()
        {
            return actividades;
        }
    }
}
