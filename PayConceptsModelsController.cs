using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CuentasXPagar.Data;
using CuentasXPagar.Models;

namespace CuentasXPagar
{
    public class PayConceptsModelsController : Controller
    {
        private Data.ApplicationDbContext db = new Data.ApplicationDbContext();

        // GET: PayConceptsModels
        public ActionResult Index()
        {
            return View(db.PayConceptsModels.ToList());
        }

        // GET: PayConceptsModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayConceptsModels payConceptsModels = db.PayConceptsModels.Find(id);
            if (payConceptsModels == null)
            {
                return HttpNotFound();
            }
            return View(payConceptsModels);
        }

        // GET: PayConceptsModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PayConceptsModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description,PayConceptsState")] PayConceptsModels payConceptsModels)
        {
            if (ModelState.IsValid)
            {
                db.PayConceptsModels.Add(payConceptsModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(payConceptsModels);
        }

        // GET: PayConceptsModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayConceptsModels payConceptsModels = db.PayConceptsModels.Find(id);
            if (payConceptsModels == null)
            {
                return HttpNotFound();
            }
            return View(payConceptsModels);
        }

        // POST: PayConceptsModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,PayConceptsState")] PayConceptsModels payConceptsModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(payConceptsModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(payConceptsModels);
        }

        // GET: PayConceptsModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayConceptsModels payConceptsModels = db.PayConceptsModels.Find(id);
            if (payConceptsModels == null)
            {
                return HttpNotFound();
            }
            return View(payConceptsModels);
        }

        // POST: PayConceptsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PayConceptsModels payConceptsModels = db.PayConceptsModels.Find(id);
            db.PayConceptsModels.Remove(payConceptsModels);
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
