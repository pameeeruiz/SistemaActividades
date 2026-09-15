using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActividades.Modelo
{
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
