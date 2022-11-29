using MVCSistemaWebTransportes.Data;
using MVCSistemaWebTransportes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSistemaWebTransportes.Controllers
{
    public class AutoController : Controller
    {
        private AutoDBContext context = new AutoDBContext();
        public AutoController() { this.context = context; }


        // GET: Auto/Index
        public ActionResult Index()
        {
            return View("Index", context.Autos.ToList());
        }

        //GET Auto/Create

        [HttpGet]
        public ActionResult Create()
        {
            Auto auto = new Auto();
            return View("Create",auto);
        }

        [HttpPost]
        public ActionResult Create(Auto auto)
        {
            if(ModelState.IsValid)
            {
                context.Autos.Add(auto);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", auto);
            }
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Auto auto = context.Autos.Find(id);
            if(auto == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View("Details", auto);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Auto auto = context.Autos.Find(id);
            if(auto == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View("Delete", auto);
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Auto auto = context.Autos.Find(id);
            if(auto !=null)
            {
                context.Autos.Remove(auto); 
                context.SaveChanges();             
            }
            return RedirectToAction("Index");
        }

    }
}