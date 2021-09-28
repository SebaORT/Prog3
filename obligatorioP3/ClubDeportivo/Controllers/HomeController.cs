﻿using Auxiliar;
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


            return View();
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