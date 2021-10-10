using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;
using Auxiliar;
using ClubDeportivo.ServiceClubSolis;

namespace ClubDeportivo.Controllers
{
    public class SocioController : Controller
    {

        Facade f1 = new Facade();

        // GET: Socio
        public ActionResult Index()
        {
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View(f1.ListarSocios());
            }

        }

        // GET: Socio/Details/5
        public ActionResult Details(int id)
        {
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                Socio s = Facade.Instance.BuscarSocio(id);
                return View(s);
            }

        }

        public ActionResult DetailsCedula(decimal cedula)
        {
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                Socio s = Facade.Instance.BuscarSocioPorCedula(cedula);
                return View("Details", s);
            }

        }

        // GET: Socio/Create
        public ActionResult Create()
        {
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                Socio s = new Socio();
                return View(s);
            }

        }

        // POST: Socio/Create
        [HttpPost]
        public ActionResult Create(Socio socio)
        {
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                // TODO: Add insert logic here
                int idSocio = f1.AltaSocio(socio.Cedula, socio.NombreApellido, socio.FechaNacimiento);

                if (idSocio > 0)
                {
                    ViewBag.Mensaje = "El socio se ha creado exitosamente";
                    return View();
                }
                else
                {
                    ViewBag.Error = "Ha ocurrido un problema";
                    return View(socio);
                }
                //Si se desea se puede modificar para devolver mensajes de error 
            }

        }

        // GET: Socio/Edit/5
        public ActionResult Edit(int id)
        {
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                Socio s = Facade.Instance.BuscarSocio(id);
                return View(s);
            }

        }

        // POST: Socio/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Socio socio)
        {
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                try
                {
                    socio.IdSocio = id;
                    bool alta = Facade.Instance.ModificarSocio(socio);

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return View(socio);
                }
            }


        }

        // GET: Socio/Delete/5
        public ActionResult Delete()
        {
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {

                ViewBag.error = "";
                return View();
            }
        }

        // POST: Socio/Delete/5
        [HttpPost]
        public ActionResult DeleteDetalle(decimal cedula)
        {
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                Socio s = Facade.Instance.BuscarSocioPorCedula(cedula);
                if (s != null)
                {
                    return View("Delete", s);
                }
                ViewBag.error = "Socio no encontrado, verifique la cedula ingresada";
                return View("Delete");
            }

        }

        public ActionResult DeleteDetalleInactivar(int idSocio) //Revisar mensajes de error 
        {
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
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

        public ActionResult BuscarPorCedula(decimal? cedula)
        {
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                if (cedula != null && cedula.HasValue)
                {
                    Socio s = Facade.Instance.BuscarSocioPorCedula(cedula.Value);
                    return View(s);
                }

                return View();
            }


        }

        /*Si tiene la mensualidad
corriente acreditada se mostrará un link que permita marcar el ingreso del socio a realizar una
actividad, y otro que permita ver todos los ingresos que realizó en una fecha dada, por defecto durante
el mes corriente.*/

        //vinculo 1...
        public ActionResult IngresoSocioActividad()
        {
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                // Create a client object with the given client endpoint configuration.
                ServiceClient clubSolisClient = new ServiceClient("BasicHttpBinding_IService");

                string dataStr = clubSolisClient.GetData(9000);

                //clubSolisClient.IngresarSocioActividad(

                //    new ActividadSocioDTO
                //    {
                //        Fecha = DateTime.Now,
                //        IdActividad = 1,
                //        IdSocio = 1
                //    }
                //    );

                return View();
            }

        }

        //vinculo2
        //      public ingresosFechaDada()
        //{

        //}

        //vinculo3
        /*
         Si aun no la pagó, se mostrará un link para navegar al registro de pago para el socio y*/
        //TODO
        //public ingresarPagoSocio

        public ActionResult CreateCuponera(decimal cedula)
        {
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View(new Cuponera());
            }

        }
        [HttpPost]
        public ActionResult CreateCuponera(decimal cedula, Cuponera c)
        {
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                int idCuponera = f1.AltaMembresia(cedula, c);
                var cuponera = (Cuponera)f1.BuscarMembresia(idCuponera);

                if (cuponera.FechaPago == null)
                {
                    cuponera.FechaPago = DateTime.Now;
                    return View("RealizarPagoCuponera", "Membresia", cuponera);
                }
                else
                {
                    return View(cuponera);
                }
            }

        }


        public ActionResult CreatePaseLibre(decimal cedula)
        {
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View(new PaseLibre());
            }

        }
        [HttpPost]
        public ActionResult CreatePaseLibre(decimal cedula, PaseLibre p)
        {
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                int idPaseLibre = f1.AltaMembresia(cedula, p);
                var paselibre = (PaseLibre)f1.BuscarMembresia(idPaseLibre);

                if (paselibre.FechaPago == null)
                {
                    paselibre.FechaPago = DateTime.Now;
                    return View("RealizarPagoLibre", "Membresia", paselibre);
                }
                else
                {
                    return View(paselibre);
                }

            }

        }


        public ActionResult ListarPaseLibrePorSocioId(int id)
        {
            Socio socio = f1.BuscarSocio(id);
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                List<Membresia> lista = f1.ListarMembresiasPorSocioId(socio);
                List<PaseLibre> ilista = new List<PaseLibre>();
                foreach (var item in lista)
                {
                    if (item.TipoMembresia == "paselibre")
                    {
                        ilista.Add((PaseLibre)item);
                    }
                }
                return View(ilista);
            }

        }

        public ActionResult ListarMCuponeraPorSocioId(int id)
        {
            Socio socio = f1.BuscarSocio(id);
            if (Session["LogueadoMail"] == null && Session["Logueado"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                List<Membresia> lista = f1.ListarMembresiasPorSocioId(socio);
                List<Cuponera> ilista = new List<Cuponera>();
                foreach (var item in lista)
                {
                    if (item.TipoMembresia == "cuponera")
                    {
                        ilista.Add((Cuponera) item);
                    }
                }
                return View(ilista);
            }

        }


    }
}
