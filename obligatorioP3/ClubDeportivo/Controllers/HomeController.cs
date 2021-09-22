using Auxiliar;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubDeportivo.Controllers
{
    public class HomeController : Controller
    {
      
        public ActionResult Index()
        {
            IRepoActividad repoActividad = FabricaRepositorios.ObtenerRepoActividad();

            //Actividad act = repoActividad.Buscar(1);

            /*var res = repoActividad.Alta(new Actividad
            {
                Active = true,
                Cupos = 600,
                EdadMax = 90,
                EdadMin = 10,
                Nombre = "Natacion Olimpica"
            });*/

            //repoActividad.Baja(3);

            //var listaActividades = repoActividad.Listar();

            Actividad actividadToUpdate = new Actividad
            {
                Id = 5,
                Nombre = "Crossfit",
                Active = true,
                Cupos = 99,
                EdadMax = 77,
                EdadMin = 15
            };

            bool res = repoActividad.Modificacion(actividadToUpdate);


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}