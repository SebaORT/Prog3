using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class PaseLibre:Membresia
    {
        /*public static double CostoFijo { get; set; }
        public static double DescuentoPaseLibre { get; set; }
        public static int AntiguedadEstablecida { get; set; }
		*/
		public override double calcularPagoFinal(Configuration config, int antiguedadSocio = 0)
		{
			double result = config.CostoFijo;
			if (antiguedadSocio > config.AntiguedadEstablecida )
			{
				result-= result * (config.DescuentoPaseLibre / 100);
			}

			return result;
		}
	}
}
