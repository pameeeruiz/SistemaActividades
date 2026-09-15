using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActividades.Modelo
{
    /// <summary>
    /// EVELYN PAMELA GUTIERREZ RUIZ 14/09/2026
    /// ESTA CLASE REPRESENTA UNA ACTIVIDAD
    /// </summary>
    public abstract class Actividad
    {
        // Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal costo { get; set; }
       

        //propiedad de tipo Responsable
        public Responsable Responsable { get; set; }

        //metodo abstracto para validar la informacion de la actividad
        public abstract bool ValidarInformacion();
    }
}
