﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Auxiliar;
using Dominio;

namespace ClubDeportivo.Controllers
{
    public class UsuarioController : Controller
    {
        Facade f1 = new Facade();

        // GET: Usuario/Create
        public ActionResult RegistrarUsuario()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult RegistrarUsuario(Usuario usuario)
        {
            // TODO: Add insert logic here
            int alta = f1.AltaUsuario(usuario.Mail, usuario.Password);
            if (alta != 0)
            {
                ViewBag.Mensaje = "Usuario creado exitosamente";
                return RedirectToAction("About", "Home");
            }
            else
            {
                ViewBag.Error = "Hubo un error al acrear el usuario"; //implementar codigo de error en usuario dominio
                return View(usuario);
            }

        }

    }
}
