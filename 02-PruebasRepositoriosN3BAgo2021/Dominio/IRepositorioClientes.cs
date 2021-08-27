using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IRepositorioClientes : IRepositorio<Cliente>
    {
        List<Cliente> ClientesConPuntajeMayorA(int puntos);
    }
}
