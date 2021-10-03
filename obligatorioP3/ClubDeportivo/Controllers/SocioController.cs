using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;
using Auxiliar;

namespace ClubDeportivo.Controllers
{
    public class SocioController : Controller
    {

        Facade f1 = new Facade();

        // GET: Socio
        public ActionResult Index()
        {
            return View(f1.ListarSocios());
        }

        // GET: Socio/Details/5
        public ActionResult Details(int id)
        {
            Socio s = Facade.Instance.BuscarSocio(id);
            return View(s);
        }

        public ActionResult DetailsCedula(decimal cedula)
        {
            Socio s = Facade.Instance.BuscarSocioPorCedula(cedula);
            return View("Details",s);
        }

        // GET: Socio/Create
        public ActionResult Create()
        {
            Socio s = new Socio();
            return View(s);
        }

        // POST: Socio/Create
        [HttpPost]
        public ActionResult Create(Socio socio)
        {
            // TODO: Add insert logic here
            int idSocio = f1.AltaSocio(socio.Cedula, socio.NombreApellido, socio.FechaNacimiento);

            if (idSocio > 0)
            {
                ViewBag.Mensaje = "El socio se ha creado exitosamente";
                return View();
            } else
            {
                ViewBag.Error = "Ha ocurrido un problema";
                return View(socio);
            }
            //Si se desea se puede modificar para devolver mensajes de error 
        }

        // GET: Socio/Edit/5
        public ActionResult Edit(int id)
        {
            Socio s = Facade.Instance.BuscarSocio(id);
            return View(s);
        }

        // POST: Socio/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Socio socio)
        {

            try
            {
                socio.IdSocio = id;
                bool alta = Facade.Instance.ModificarSocio(socio);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View(socio);
            }
        }

        // GET: Socio/Delete/5
        public ActionResult Delete()
        {
            ViewBag.error = "";
            return View();
        }

        // POST: Socio/Delete/5
        [HttpPost]
        public ActionResult DeleteDetalle(decimal cedula)
        {
            Socio s = Facade.Instance.BuscarSocioPorCedula(cedula);
            if(s != null)
            {
                return View("Delete", s);
            }
            ViewBag.error = "Socio no encontrado, verifique la cedula ingresada";
            return View("Delete");
        }

        public ActionResult DeleteDetalleInactivar(int idSocio) //Revisar mensajes de error 
        {
            bool baja = Facade.Instance.BajaSocio(idSocio);
            if (baja)
            {
                ViewBag.error = "Baja existosa";
                return View("Delete");
            }
            ViewBag.error = "Ha ocurrido un error";
            return View("Delete");            
        }
    }
}
