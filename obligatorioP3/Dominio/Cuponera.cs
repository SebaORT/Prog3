using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cuponera:Membresia
    {
        public int CantActividades { get; set; }
       /* public static int CantActividadesDescuento { get; set; } //Cantidad mínima para realizar descuento 
        public static double DescuentoCuponera { get; set; }
	   */
		public Cuponera(int cantActividadesMes)
		{
			CantActividades = cantActividadesMes; // minimo 8 maximo 60
		}

		public override double calcularPagoFinal(Configuration config, int antiguedadSocio = 0)
		{
			var result = config.MontoUnitarioCuponera * CantActividades;

			if (CantActividades > config.CantActividadesDescuento)
			{
				double descuento = config.DescuentoCuponera/100;
				result -= descuento * result;
			}
			
			
			return result;
		}
	}
}
