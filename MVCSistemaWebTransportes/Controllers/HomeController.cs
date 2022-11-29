using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSistemaWebTransportes.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Fecha = DateTime.Now.ToString();
            ViewBag.Message = "Bienvenido al Sitio Web";
            return View();
        }

    }
}