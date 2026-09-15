using SistemaActividades.Datos;
using SistemaActividades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActividades.Negocio
{
    public class ActividadNegocio
    {
        private ActividadDatos datos = new ActividadDatos();

        private int siguienteId = 1;

        public void Registrar(Actividad actividad)
        {
            if (actividad.costo <= 0)
            {
                throw new ArgumentException("El costo debe ser mayor a cero");
            }
            if (!actividad.ValidarInformacion())
            {
                throw new ArgumentException("La información de la actividad no es válida");
                
            }

            actividad.Id = siguienteId;
            siguienteId++;
            datos.AgregarActividad(actividad);

        }

        public System.Collections.Generic.List<Actividad> ObtenerTodas()
        {
            return datos.ObtenerTodas();
        }
    }
}
