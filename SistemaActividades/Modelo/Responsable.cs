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
    public class Responsable
    {
        // Propiedades
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        // Constructor
        public Responsable(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }
    }

}
