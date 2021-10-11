using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorios;
using System.Data;
using System.Web;

namespace Auxiliar
{
    public class Facade
    {
        public static Configuration Configuration { get; set; }
        public static Dictionary<int, Actividad> ActividadesClub { get; set; }
        private static Dictionary<int, Socio> mapSocio;// = new Dictionary<int, Socio>();
        private static Dictionary<int, Actividad> mapActividad;// = new Dictionary<int, Actividad>();

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

        public static void ActualizarActividadesClub()
        {
            Facade.ActividadesClub = new Dictionary<int, Actividad>();
            IRepoActividad ra = FabricaRepositorios.ObtenerRepoActividad();

            List<Actividad> actividades = ra.Listar();
            foreach (var act in actividades)
            {
                act.Horarios = ra.ListarHorariosActividad(act.Id);

                Facade.ActividadesClub.Add(act.Id, act);
            }
        }

        public Facade()
        {
        }

        #region metodos

        public int AltaMembresia(decimal cedula, Membresia m)
        {
            IRepoMembresia rm = FabricaRepositorios.ObtenerRepoMembresia();
            IRepoSocios rs = FabricaRepositorios.ObtenerRepoSocios();
            int idSocio = rs.BuscarPorCedula(cedula).IdSocio;
            //Aqui se hace el alta de la membresia y al mismo tiempo se le asigna al socio indicado
            int idMembresia = FabricaRepositorios.ObtenerRepoMembresia().Alta(idSocio, m);
            //se agrega la membresia a la lista del socio

            Socio s = rs.BuscarPorCedula(cedula);
            Membresia mem = rm.Buscar(idMembresia);
            s.Membresias.Add(mem);
            return idMembresia;
        }

        public List<ActividadHora> GetActividadesDia(int edadSocio)
        {
            List<ActividadHora> result = new List<ActividadHora>();
            DateTime _now = DateTime.Now;

            foreach (Actividad actividad in ActividadesClub.Values)
            {

                if (actividad.Cupos > 0 && edadSocio >= actividad.EdadMin && edadSocio <=actividad.EdadMax)
                {
                    foreach (var h in actividad.Horarios)
                    {
                        if (h.DiaSemana == _now.DayOfWeek && h.Hora > _now.Hour) //verificar si puede entrar a la actividad
                        {
                            result.Add(new ActividadHora
                            {
                                Id = actividad.Id,
                                Hora = h.Hora,
                                Nombre = actividad.Nombre
                            });
                        }
                    }
                }
            }

            return result.OrderByDescending(e => e.Hora).ToList();

        }



        private bool TieneHorarioDiaActividad(List<Horario> horariosActividad)
        {
            DateTime _now = DateTime.Now;

            foreach (var h in horariosActividad)
            {
                if (h.DiaSemana == _now.DayOfWeek && h.Hora > _now.Hour) //verificar si puede entrar a la actividad
                {
                    return true;
                }
            }
            return false;
        }

        /*private DayOfWeek GetDiaSemana(DayOfWeek diaSemana)
		{
			throw new NotImplementedException();
		}*/

        public bool BajaMembresia(int id)
        {
            IRepoMembresia rm = FabricaRepositorios.ObtenerRepoMembresia();
            return rm.Baja(id);
        }

        public bool ModificacionMembresia(Membresia m)
        {
            return FabricaRepositorios.ObtenerRepoMembresia().Modificacion(m);
        }

        public bool ModificacionFechaPagoHoyMembresia(Membresia m)
        {
            IRepoMembresia rm = FabricaRepositorios.ObtenerRepoMembresia();
            bool res = rm.ModificarFechaPagoHoy(m);
            return res;
        }

        public List<Membresia> ListarMembresias()
        {
            IRepoMembresia rm = FabricaRepositorios.ObtenerRepoMembresia();
            return rm.Listar();
        }

        public List<Membresia> ListarMembresiasPorSocioId(Socio socio)
        {
            //IRepoMembresia rm = FabricaRepositorios.ObtenerRepoMembresia();
            //List<Membresia> lista = rm.ListarPorSocioId(socio.IdSocio);
            //mapSocio[socio.IdSocio].Membresias.Clear();
            //List<Membresia> listaSocio = mapSocio[socio.IdSocio].Membresias;
            //foreach (var item in lista)
            //{
            //    if (item.TipoMembresia == "cuponera")
            //    {
            //        listaSocio.Add((Cuponera)item);
            //    }

            //    if (item.TipoMembresia == "paselibre")
            //    {
            //        listaSocio.Add((PaseLibre)item);
            //    }
            //}

            try
            {
                return mapSocio[socio.IdSocio].Membresias;
            } catch(Exception err)
            {
                return new List<Membresia>();
            }
            //return mapSocio[socio.IdSocio].Membresias; //socio.Membresias;
        }

        public List<Actividad> ListarActividades()
        {
            return new List<Actividad>();
        }

        public Actividad BuscarActividad(int id)
        {
            return new Actividad();
        }

        public int AltaSocio(Socio socio)
        {
            int idSocio = 0;

            if (Socio.ValidarDatos(socio))
            {
                IRepoSocios rs = FabricaRepositorios.ObtenerRepoSocios();
                Socio s = new Socio()
                {
                    Cedula = socio.Cedula,
                    NombreApellido = socio.NombreApellido,
                    FechaNacimiento = socio.FechaNacimiento,
                    FechaIngreso = DateTime.Now.ToLocalTime(),
                    Activo = true
                };

                idSocio = rs.Alta(s);
            }

            return idSocio;
        }

        public bool BajaSocio(int id)
        {
            bool s = FabricaRepositorios.ObtenerRepoSocios().Baja(id);
            return s;
        }

        public bool ModificarSocio(Socio socio)
        {
            return FabricaRepositorios.ObtenerRepoSocios().Modificacion(socio);
        }

        public Socio BuscarSocio(int id)
        {
            Socio s = FabricaRepositorios.ObtenerRepoSocios().Buscar(id);
            return s;
        }

        public Socio ActualizarSocio(Socio socio)
        {
            if (socio == null)
            {
                return null;
            }

            IRepoSocios rs = FabricaRepositorios.ObtenerRepoSocios();
            List<Membresia> membresia = FabricaRepositorios.ObtenerRepoMembresia().Listar();
            List<SocioMembresia> socioMembresia = rs.ListarSocioMembresia();

            List<SocioActividad> socioActividades = rs.ListarSocioActividad();

            foreach (SocioMembresia m in socioMembresia)
            {
                if (socio.IdSocio == m.IdSocio)
                {
                    Membresia mem = BuscarMembresiaEnLista(membresia, m.IdMembresia);
                    if (mem != null)
                    {
                        socio.Membresias.Add(mem);
                    }
                    else
                    {
                        throw new Exception("Base de datos inconsisitente");
                    }
                }

            }


            foreach (SocioActividad sa in socioActividades)
            {
                if (socio.IdSocio == sa.IdSocio)
                {
                    Actividad actividad =
                                        Facade.ActividadesClub.ContainsKey(sa.IdActividad) ? Facade.ActividadesClub[sa.IdActividad] :
                                         null;

                    if (actividad != null)
                    {
                        socio.ActividadSocios.Add(new ActividadSocio
                        {
                            Actividad = actividad,
                            Socio = socio,
                            Fecha = sa.Fecha
                        });
                    }
                    else
                    {
                        throw new Exception("Base de datos inconsisitente");
                    }
                }

            }

            return socio;
        }

        public List<Socio> ListaroActualizarSocios()
        {
            mapSocio = new Dictionary<int, Socio>();
            mapActividad = new Dictionary<int, Actividad>();

            IRepoSocios rs = FabricaRepositorios.ObtenerRepoSocios();
            List<Socio> lista = rs.Listar();
            List<Membresia> membresia = FabricaRepositorios.ObtenerRepoMembresia().Listar();
            List<SocioMembresia> socioMembresia = rs.ListarSocioMembresia();

            List<SocioActividad> socioActividades = rs.ListarSocioActividad();

            foreach (SocioMembresia m in socioMembresia)
            {
                Socio socio = null;
                if (!mapSocio.ContainsKey(m.IdSocio))
                {
                    socio = BuscarSocioEnLista(lista, m.IdSocio);
                    mapSocio.Add(m.IdSocio, socio);
                }
                else
                {
                    socio = mapSocio[m.IdSocio];
                }


                Membresia mem = BuscarMembresiaEnLista(membresia, m.IdMembresia);
                if (socio != null && mem != null)
                {
                    socio.Membresias.Add(mem);
                }
                else
                {
                    throw new Exception("Base de datos inconsisitente");
                }
            }


            foreach (SocioActividad sa in socioActividades)
            {
                Socio socio = mapSocio.ContainsKey(sa.IdSocio) ? mapSocio[sa.IdSocio] : null;

                Actividad actividad =
                    Facade.ActividadesClub.ContainsKey(sa.IdActividad) ? Facade.ActividadesClub[sa.IdActividad] :
                     null;


                if (socio != null && actividad != null)
                {
                    socio.ActividadSocios.Add(new ActividadSocio
                    {
                        Actividad = actividad,
                        Socio = socio,
                        Fecha = sa.Fecha
                    });
                }
                else
                {
                    throw new Exception("Base de datos inconsisitente");
                }
            }

            return lista;
        }

        private Membresia BuscarMembresiaEnLista(List<Membresia> membresia, int idMembresia)
        {
            foreach (var m in membresia)
            {
                if (m.Id == idMembresia)
                {
                    return m;
                }
            }
            return null;
        }

        public Membresia BuscarMembresia(int idMembresia)
        {
            foreach (var m in ListarMembresias())
            {
                if (m.Id == idMembresia)
                {
                    return m;
                }
            }
            return null;
        }

        private Socio BuscarSocioEnLista(List<Socio> lista, int idSocio)
        {
            foreach (var s in lista)
            {
                if (s.IdSocio == idSocio)
                {
                    return s;
                }
            }
            return null;
        }

        public int AltaUsuario(string email, string contrasenia)
        {
            IRepoUsuario ru = FabricaRepositorios.ObtenerRepoUsuarios();

            int existe = ru.buscarLogin(email, contrasenia);

            if (existe == -1)
            {
                //en caso de que no exista
                Usuario u = new Usuario()
                {
                    Mail = email,
                    Password = contrasenia
                };

                int res = ru.Alta(u);
                return res;
            }
            else
            {
                //en caso de que ya exista
                return 0;
            }
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
        {
            try
            {
                IRepoSocios ru = FabricaRepositorios.ObtenerRepoSocios();
                IRepoConfig repoConfig = FabricaRepositorios.ObtenerRepoConfig();
                // Configuration config = repoConfig.Buscar(1);


                Socio socio = ru.BuscarPorCedula(cedulaSocio);

                return socio.TotalAPagarMensualidad(Facade.Configuration);

            }
            catch (Exception ex)
            {
                return -1;

            }
        }

        public bool ExportarInfo(string dir)
        {
            var repoActividad = FabricaRepositorios.ObtenerRepoActividad();
            var repoConfig = FabricaRepositorios.ObtenerRepoConfig();
            var repoMembresia = FabricaRepositorios.ObtenerRepoMembresia();
            var repoSocios = FabricaRepositorios.ObtenerRepoSocios();
            var repoUsuarios = FabricaRepositorios.ObtenerRepoUsuarios();

            DataTable actividades = repoActividad.ListarDataTable();
            DataTable actividadHorarios = repoActividad.ListarActividadHorarioDataTable();


            DataTable configuration = repoConfig.ListarDataTable();
            DataTable membresias = repoMembresia.ListarDataTable();
            DataTable socios = repoSocios.ListarDataTable();
            DataTable usuarios = repoUsuarios.ListarDataTable();

            DataTable socioActividad = repoSocios.ListarSocioActividadDataTable();
            DataTable socioMembresia = repoSocios.ListarSocioMembresiaDataTable();


            socios.ToCSV($"{dir}socios.csv", "|");
            socioActividad.ToCSV($"{dir}socioActividad.csv", "|");
            socioMembresia.ToCSV($"{dir}socioMembresia.csv", "|");
            actividades.ToCSV($"{dir}actividades.csv", "|");
            actividadHorarios.ToCSV($"{dir}actividadHorarios.csv", "|");
            membresias.ToCSV($"{dir}membresias.csv", "|");
            usuarios.ToCSV($"{dir}usuarios.csv", "|");


            return true;
        }



        public Socio BuscarSocioPorCedula(decimal cedula)
        {
            Socio s = FabricaRepositorios.ObtenerRepoSocios().BuscarPorCedula(cedula);
            return s;
        }



        #endregion metodos

    }
}
