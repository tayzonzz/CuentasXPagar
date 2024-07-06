using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CuentasXPagar.Models;

namespace CuentasXPagar
{
    public class ProvidersModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ProvidersModels
        public ActionResult Index()
        {
            return View(db.ProvidersModels.ToList());
        }

        // GET: ProvidersModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProvidersModels providersModels = db.ProvidersModels.Find(id);
            if (providersModels == null)
            {
                return HttpNotFound();
            }
            return View(providersModels);
        }

        // GET: ProvidersModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProvidersModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PersonType,Name,CedulaOrRNC,Balance,State")] ProvidersModels providersModels)
        {
            if (ModelState.IsValid)
            {
                db.ProvidersModels.Add(providersModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(providersModels);
        }

        // GET: ProvidersModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProvidersModels providersModels = db.ProvidersModels.Find(id);
            if (providersModels == null)
            {
                return HttpNotFound();
            }
            return View(providersModels);
        }

        // POST: ProvidersModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PersonType,Name,CedulaOrRNC,Balance,State")] ProvidersModels providersModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(providersModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(providersModels);
        }

        // GET: ProvidersModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProvidersModels providersModels = db.ProvidersModels.Find(id);
            if (providersModels == null)
            {
                return HttpNotFound();
            }
            return View(providersModels);
        }

        // POST: ProvidersModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProvidersModels providersModels = db.ProvidersModels.Find(id);
            db.ProvidersModels.Remove(providersModels);
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
