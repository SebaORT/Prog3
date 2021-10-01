using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorios;

namespace Auxiliar
{
    public class Facade
    {
        public static Facade _instance = null;
        public static Facade Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Facade();
                }

                return _instance;
            }
        }

        public Facade()
        {
        }

        #region metodos

        public int AltaMembresia(int cedula, Membresia tipo)
        {
            return 0;
        }

        public int BajaMembresia(int id)
        {
            return 0;
        }

        public int ModificacionMembresia(int id)
        {
            return 0;
        }

        public int BuscarMembresia(int cedula)
        {
            return 0;
        }

        public List<Membresia> ListarMembresias()
        {
            return new List<Membresia>();
        }

        public List<Actividad> ListarActividades()
        {
            return new List<Actividad>();
        }

        public Actividad BuscarActividad(int id)
        {
            return new Actividad();
        }

        public int AltaSocio(int cedula, string nombre, string apellido, DateTime fechaNacimiento)
        {
            return 0;
        }

        public int BajaSocio(int cedula)
        {
            return 0;
        }

        public int ModificarSocio(int cedula, string nombre, string apellido)
        {
            return 0;
        }

        public Socio BuscarSocio(int cedula)
        {
            return new Socio();
        }

        public List<Socio> ListarSocios()
        {
            return new List<Socio>();
        }

        public int IngresoSocioActividad(int cedulaSocio, int idActividad)
        {
            return 0;
        }

        public int AltaUsuario(string email, string contrasenia)
        {
            IRepoUsuario ru = FabricaRepositorios.ObtenerRepoUsuarios();

            Usuario u = new Usuario()
            {
                Mail = email,
                Password = contrasenia
            };

            int res = ru.Alta(u);
            return res;
        }

        public int LoginUsuario(string mail, string password)
        {
            IRepoUsuario ru = FabricaRepositorios.ObtenerRepoUsuarios();

            int existe = ru.buscarLogin(mail, password);

            return existe;
        }

        public int LogOutUsuario(string email)
        {
            return 0;
        }

        public double PagarMensualidadSocio(int cedulaSocio)
        {try
            {
                IRepoSocios ru = FabricaRepositorios.ObtenerRepoSocios();
                IRepoConfig repoConfig = FabricaRepositorios.ObtenerRepoConfig();
                Configuration config = repoConfig.Buscar(1);


                Socio socio = ru.BuscarPorCedula(cedulaSocio);

                return socio.TotalAPagarMensualidad(config); ;

            }
            catch (Exception ex)
			{
                return -1;

			}
        }

        public bool ExportarInfo()
        {
            return true;
        }

        #endregion metodos

    }
}
