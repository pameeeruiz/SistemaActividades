using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActividades.Modelo
{
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
