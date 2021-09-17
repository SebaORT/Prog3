using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorios;

namespace Auxiliar
{
    public class FabricaRepositorios
    {
        public static IRepoActividad ObtenerRepoActividad()
        {
            return new RepoActividad();
        }
        public static IRepoMembresia ObtenerRepoMembresia()
        {
            return new RepoMembresia();
        }

        public static IRepoSocios ObtenerRepoSocios()
        {
            return new RepoSocios();
        }

        public static IRepoUsuario ObtenerRepoUsuarios()
        {
            return new RepoUsuario();
        }
    }
}
