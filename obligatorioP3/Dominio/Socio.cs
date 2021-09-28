using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Socio
    {
        public int IdSocio { get; set; }
        public string NombreApellido { get; set; }
        public decimal Cedula { get; set; } //Se le agrega número de socio? Ci dato único 
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Activo { get; set; }
        public List<Membresia> Membresias { get; set; }

		public double TotalAPagarMensualidad(Configuration config)
		{
            //TODO
            double result = 0;
            foreach (Membresia m in Membresias)
			{
                result += m.calcularPagoFinal(config);
			}
			throw new NotImplementedException();
		}
	}
}
