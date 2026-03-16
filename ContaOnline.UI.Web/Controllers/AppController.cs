using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContaOnline.UI.Web.Controllers
{
    public class AppController : Controller
    {
        // Tela Inicial
        public ActionResult Inicio()
        {
            return View();
        }

        // Tela Registro
        public ActionResult Registro()
        {
            return View();
        }

        // Tela Sobre
        public ActionResult Sobre()
        {
            return View();
        }
    }
}