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
            return View(s);
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
            return View();
        }

        // POST: Socio/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Socio/Delete/5
        public ActionResult Delete(decimal cedula)
        {
            Socio s = Facade.Instance.BuscarSocioPorCedula(cedula);
            if(s != null)
            {
                
            }
            return View("EliminarSocio", s);
        }

        // POST: Socio/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
