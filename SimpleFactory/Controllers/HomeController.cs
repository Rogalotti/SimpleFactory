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

            var ListFactories = db.Factories.ToList();

            return View(ListFactories);
        }

        [HttpPost]
        public ActionResult Index(string searchTerm)
        {

            List<Factory> factories;

            if (string.IsNullOrEmpty(searchTerm))
            {
                factories = db.Factories.ToList();
            }
            else
            {
                factories = db.Factories.Where(x => x.FactoryName.StartsWith(searchTerm)).ToList();
            }

            return View(factories);
        }


    }
}