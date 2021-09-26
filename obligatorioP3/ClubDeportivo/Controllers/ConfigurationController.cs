using Auxiliar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubDeportivo.Controllers
{
    public class ConfigurationController : Controller
    {
        // GET: Configuration
        public ActionResult Index()
        {
            return RedirectToAction("Details");
        }

        // GET: Configuration/Details/
        public ActionResult Details()
        {
            var configRepo = FabricaRepositorios.ObtenerRepoConfig();

            var config = configRepo.Buscar(1);

            return View(config);
        }
    }
}
