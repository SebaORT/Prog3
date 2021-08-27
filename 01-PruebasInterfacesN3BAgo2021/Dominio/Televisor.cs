using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Televisor : IDispositivoAV
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int NroSerie { get; set; }

        public override string ToString()
        {
            return Marca + " " + Modelo + " " + NroSerie;
        }

        public bool Apagar()
        {
            return true;
        }

        public bool Encender()
        {
            return true;
        }

        public int SubirVolumen()
        {
            return 0;
        }

        public int BajarVolumen()
        {
            return 0;
        }

        public int AumentarBrillo()
        {
            return 0;
        }

        public int DisminuirBrillo()
        {
            return 0;
        }

    }
}
