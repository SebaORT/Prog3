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
        public List<ActividadSocio> ActividadSocios { get; set; }
		public double TotalAPagarMensualidad(Configuration config)
		{
            double result = 0;
            foreach (Membresia m in Membresias)
			{
                result += m.calcularPagoFinal(config);
			}

            return result;
			//throw new NotImplementedException();
		}

       public static bool ValidarDatos(decimal ci, string nomApe, DateTime fNacimiento)
        {
            int esInt = (int) Math.Floor(ci);
            bool result = false; 
            if (esInt == (int)ci && esInt >999999 && esInt < 1000000000) {
                int largo = nomApe.Length;
                int comparar = nomApe.Trim().Length;
                if (largo == comparar && largo >= 6) {
                    int a = Math.Abs(fNacimiento.Year - DateTime.Today.Year);
                    if(a >= 3)
                    {
                        result = true;
                    }
                }
            }


            return result;
        }


    }
}
