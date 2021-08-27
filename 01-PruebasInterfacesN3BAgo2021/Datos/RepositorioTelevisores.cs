using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class RepositorioTelevisores : IRepositorio<Televisor>
    {
        public bool Alta(Televisor t)
        {
            throw new NotImplementedException();
        }

        public bool Baja(int id)
        {
            throw new NotImplementedException();
        }

        public Televisor Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Modificacion(Televisor t)
        {
            throw new NotImplementedException();
        }

        public List<Televisor> TraerTodo()
        {
            throw new NotImplementedException();
        }
    }
}
