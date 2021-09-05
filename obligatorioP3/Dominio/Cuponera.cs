using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Cuponera:Membresia
    {
        public int CantActividadades { get; set; }
        public double Descuento { get; set; }

        public static int CantActividadesDescuento { get; set; } //Cantidad mínima para realizar descuento 
    }
}
