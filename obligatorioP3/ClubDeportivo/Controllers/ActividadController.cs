using Auxiliar;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubDeportivo.Controllers
{
    public class ActividadController : Controller
    {
        // GET: Actividad
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

        // GET: Actividad/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Actividad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Actividad/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Actividad/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Actividad/Edit/5
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

        // GET: Actividad/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Actividad/Delete/5
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
