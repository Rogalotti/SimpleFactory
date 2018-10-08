using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SimpleFactory.DAL;
using SimpleFactory.Models;
using SimpleFactory.ViewModels;

namespace SimpleFactory.Controllers
{
    public class EmployersController : Controller
    {
        private FactoryContext db = new FactoryContext();

        // GET: Employers
        public ActionResult Index()
        {
            return View(db.Employers.ToList());
        }

        // GET: Employers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employer = db.Employers.Where(x => x.FactoryId == id);
            if (employer == null)
            {
                return HttpNotFound();
            }
            return View(employer.ToList());
        }

        // GET: Employers/Create
        public ActionResult Create()
        {
            var listOfFactories =  db.Factories.ToList();           
            SelectList list = new SelectList(listOfFactories, "FactoryId", "FactoryName");
            ViewBag.FactoryListName = list;
            
            return View();
        }

        // POST: Employers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployerId,FirstName,LastName,PhoneNumber,FactoryId")] Employer employer)
        {
            if (ModelState.IsValid)
            {
                var listOfFactories = db.Factories.ToList();
                SelectList list = new SelectList(listOfFactories, "FactoryId", "FactoryName");
                ViewBag.FactoryListName = list;
                db.Employers.Add(employer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employer);
        }

        // GET: Employers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employer employer = db.Employers.Find(id);
            if (employer == null)
            {
                return HttpNotFound();
            }

            var listOfFactories = db.Factories.ToList();
            SelectList list = new SelectList(listOfFactories, "FactoryId", "FactoryName");
            ViewBag.FactoryListName = list;

            return View(employer);
        }

        // POST: Employers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployerId,FirstName,LastName,PhoneNumber,FactoryId")] Employer employer)
        {
            if (ModelState.IsValid)
            {
                var listOfFactories = db.Factories.ToList();
                SelectList list = new SelectList(listOfFactories, "FactoryId", "FactoryName");
                ViewBag.FactoryListName = list;

                db.Entry(employer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employer);
        }

        // GET: Employers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employer employer = db.Employers.Find(id);
            if (employer == null)
            {
                return HttpNotFound();
            }
            return View(employer);
        }

        // POST: Employers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employer employer = db.Employers.Find(id);
            db.Employers.Remove(employer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
