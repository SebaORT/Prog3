using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Actividad
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; } //Nombre único
        public int RangoEdad { get; set; }
        public DateTime Horario { get; set; }
        public int Cupos { get; set; } 

    }
}
