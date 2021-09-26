using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auxiliar
{
    public class Facade
    {
        public static Facade _instance = null;

        private FabricaRepositorios _fabricaRepositorios;

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
            _fabricaRepositorios = new FabricaRepositorios();
        }

        #region metodos

        public FabricaRepositorios FabricaRepositorios()
        {
            return new FabricaRepositorios();
        }

        public int AltaMembresia(int cedula, Membresia tipo)
        {
            Membresia m1 = new Membresia();
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
            return 0;
        }

        public int LoginUsuario(string email, string contrasenia)
        {
            return 0;
        }

        public int LogOutUsuario(string email)
        {
            return 0;
        }

        public int PagarMensualidadSocio(int cedulaSocio)
        {
            return 0;
        }

        public bool ExportarInfo()
        {
            return true;
        }

        #endregion metodos

    }
}
