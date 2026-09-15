using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActividades.Modelo
{
    /// <summary>
    /// EVELYN PAMELA GUTIERREZ RUIZ 14/09/2026
    /// ESTA CLASE REPRESENTA A UNA ACTIVIDAD DE BOLICHE, CONTENIENDO SU NÚMERO DE PISTAS.
    /// </summary>
    public class Boliche : Actividad
    {
        // Propiedad
        public int NumeroPistas { get; set; }

        public override bool ValidarInformacion()
        {
            // Implementación de la validación para la actividad de boliche
            return !string.IsNullOrWhiteSpace(Nombre) 
                && costo > 0
                && Responsable != null;
        }
    }
}
