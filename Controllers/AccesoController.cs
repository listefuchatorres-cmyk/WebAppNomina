using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppNomina.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Autenticar()
        {
            return View();
        }

        public ActionResult Registro()
        {

            return View();
        }
       
    }
}
