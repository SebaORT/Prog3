using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class RepoClientes : IRepositorioClientes
    {
        public bool Alta(Cliente t)
        {
            throw new NotImplementedException();
        }

        public bool Baja(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ClientesConPuntajeMayorA(int puntos)
        {
            throw new NotImplementedException();
        }

        public bool Modificacion(Cliente t)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> TraerTodo()
        {
            throw new NotImplementedException();
        }
    }
}
