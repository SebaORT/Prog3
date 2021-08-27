using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IDispositivoVideo : IElectrodomestico
    {
        int AumentarBrillo();
        int DisminuirBrillo();
    }
}
