using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Actividad
    {
        public int Id { get; set; }
        public string Nombre { get; set; } //Nombre único
        public int EdadMax { get; set; }
        public int EdadMin { get; set; }
        public int Cupos { get; set; } 
        public bool Active { get; set; }
        public static double Costo { get; set; }
        public List<Horario>  Horarios { get; set; }

    }
}
