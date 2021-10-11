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


        public Socio()
        {

            Membresias = new List<Membresia>();
            ActividadSocios = new List<ActividadSocio>();
        }

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

        public static bool ValidarDatos(Socio socio)
        {
            string nomApe = socio.NombreApellido;
            DateTime fNacimiento = socio.FechaNacimiento;
            int esInt = (int)Math.Floor(socio.Cedula);
            string textoCI = esInt.ToString();

            if (textoCI.Length >= 7 && textoCI.Length <= 9)
            {
                int largo = nomApe.Length;
                int comparar = nomApe.Trim().Length;
                //si el primer o ultimo caracter son espacios
                if (nomApe[0].Equals(' ') || nomApe[largo - 1].Equals(' '))
                {
                    return false;
                }

                if (largo == comparar && largo >= 6 && nomApe.Contains(" "))
                {
                    int a = Math.Abs(fNacimiento.Year - DateTime.Today.Year);
                    if (a >= 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ValidarPagoMembresia()
        {
            bool result = false;
            DateTime mesAnio = DateTime.Now;
            int mes = mesAnio.Month;
            int anio = mesAnio.Year;

            foreach (Membresia m in Membresias)
            {
                if (m.FechaPago != null && m.FechaPago.HasValue && m.FechaPago.Value.Month == mes && m.FechaPago.Value.Year == anio)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
