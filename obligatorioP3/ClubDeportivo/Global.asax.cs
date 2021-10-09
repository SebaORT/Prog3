using Auxiliar;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ClubDeportivo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var repoConfig = FabricaRepositorios.ObtenerRepoConfig();
            Configuration configuration =  repoConfig.Buscar(1);
            Facade.Configuration = configuration;

            Facade.ActividadesClub = new Dictionary<int, Actividad>();
            IRepoActividad ra = FabricaRepositorios.ObtenerRepoActividad();

            List<Actividad> actividades = ra.Listar();
            foreach (var act in actividades)
            {
                act.Horarios = ra.ListarHorariosActividad(act.Id);

                Facade.ActividadesClub.Add(act.Id, act);
            }
        }
    }
}
