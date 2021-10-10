using Auxiliar;
using ClubDeportivo.ServiceClubSolis;
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
            ViewBag.logueado = Session["Logueado"];
            ViewBag.mail = Session["LogueadoMail"];

            //TEST
            //double mensualidad =  Facade.Instance.PagarMensualidadSocio(45042994);


            // Create a client object with the given client endpoint configuration.
            /*            ServiceClient clubSolisClient = new ServiceClient("BasicHttpBinding_IService");

                        string dataStr = clubSolisClient.GetData(9000);
            */

          //  Facade.Instance.ExportarInfo();


            return View();
        }

        public ActionResult Export()
		{
            string dir = ControllerContext.HttpContext.Server.MapPath("../Export/");
            try
            {
                Facade.Instance.ExportarInfo(dir);
                ViewBag.Message = "Informacion Exportada Exitosamente";
                return View("Success");
            }
            catch (Exception ex)
			{
                ViewBag.Message = ex.Message;
                return View("Error");
			}
                
		}
        public ActionResult About()
        {
            ViewBag.Message = "Gestion Club Solis";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "clubSolis@solis.com";

            return View();
        }
    }
}