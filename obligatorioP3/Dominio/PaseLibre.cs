using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class PaseLibre:Membresia
    {
        public static double CostoFijo { get; set; }
        public static double DescuentoPaseLibre { get; set; }
        public static int AntiguedadEstablecida { get; set; }
    }
}
