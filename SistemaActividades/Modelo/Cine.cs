using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActividades.Modelo
{
    /// <summary>
    /// EVELYN PAMELA GUTIERREZ RUIZ 14/09/2026
    /// ESTA CLASE REPRESENTA A UNA ACTIVIDAD DE CINE, CONTENIENDO SU NÚMERO DE SALA.
    /// </summary>
    public class Cine : Actividad
    {
        // Propiedad
        public int Sala { get; set; }

        public override bool ValidarInformacion()
        {
            // Implementación de la validación para la actividad de cine
            return !string.IsNullOrWhiteSpace(Nombre) 
                && costo > 0
                && Responsable != null;
        }
    }
}
