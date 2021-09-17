using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Membresia
    {
        public DateTime FechaPago { get; set; }
        public bool Activa { get; set; }
        public List<Actividad> Actividades { get; set; }
        
    }
}
