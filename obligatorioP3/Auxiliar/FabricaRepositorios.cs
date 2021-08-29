using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Datos;

namespace Auxiliar
{
    public class FabricaRepositorios
    {
        public static IRepositorioProductos ObtenerRepoProductos()
        {
            return new RepoProductos();
        }

        public static IRepositorioClientes ObtenerRepoClientes()
        {
            IRepositorioClientes repo = new RepoClientes();
            return repo;
        }
    }
}
