using Mvc_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_ASP.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var m = new MiModelo();
            m.Nombre = "Pancho";
            m.Apellidos = "Perez";
            m.Edad = 30;
            return View(m);
        }

    }
}
