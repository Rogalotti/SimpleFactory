using SimpleFactory.DAL;
using SimpleFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleFactory.Controllers
{
    public class HomeController : Controller
    {

        private FactoryContext db = new FactoryContext();

        // GET: Home
        public ActionResult Index()
        {

            Factory faktor = new Factory { FactoryId = 1, FactoryName = "lol" };
            db.Factories.Add(faktor);
            db.SaveChanges();


            return View();
        }
    }
}