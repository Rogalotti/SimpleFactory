using SimpleFactory.DAL;
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

            


            return View();
        }
    }
}