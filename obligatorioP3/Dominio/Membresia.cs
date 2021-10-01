using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Membresia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descipcion { get; set; }
        public DateTime FechaPago { get; set; }
        public bool Active { get; set; }
        public int CantActividades { get; set; }
        public string TipoMembresia { get; set; }

        public abstract double calcularPagoFinal(Configuration config, int antiguedadSocio = 0);

	}
}
