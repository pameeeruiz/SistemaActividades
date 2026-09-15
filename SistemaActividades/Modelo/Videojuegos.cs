using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActividades.Modelo
{
    /// <summary>
    /// EVELYN PAMELA GUTIERREZ RUIZ 14/09/2026
    /// ESTA CLASE REPRESENTA A UN RESPONSABLE DE UNA ACTIVIDAD, CONTENIENDO SU NOMBRE Y CARGO.
    /// </summary>
    public class Videojuegos : Actividad
    {
        // Propiedad
        public string ConsolaPrincipal { get; set; }

        public override bool ValidarInformacion()
        {
            // Implementación de la validación para la actividad de videojuegos
            return !string.IsNullOrWhiteSpace(Nombre)
                && costo > 0
                && Responsable != null;
        }
    }
}
