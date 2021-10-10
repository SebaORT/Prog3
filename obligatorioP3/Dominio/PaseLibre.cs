using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class PaseLibre:Membresia
    {
		public PaseLibre():base()
        {
			TipoMembresia = "paselibre";
			Active = true;

		}
		public override double calcularPagoFinal(Configuration config, int antiguedadSocio = 0)
		{
			double result = config.CostoFijo;

			//TODO calcular antiguedadSocio....
			if (antiguedadSocio > config.AntiguedadEstablecida )
			{
				result-= result * (config.DescuentoPaseLibre / 100);
			}

			return result;
		}
	}
}
