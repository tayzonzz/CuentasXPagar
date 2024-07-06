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
    public class DocumentsModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DocumentsModels
        public ActionResult Index()
        {
            return View(db.DocumentsModels.ToList());
        }

        // GET: DocumentsModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocumentsModels documentsModels = db.DocumentsModels.Find(id);
            if (documentsModels == null)
            {
                return HttpNotFound();
            }
            return View(documentsModels);
        }

        // GET: DocumentsModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DocumentsModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DocumentNumber,InvoiceNumber,DocumentDate,Price,RecordDate,Proveedor")] DocumentsModels documentsModels)
        {
            if (ModelState.IsValid)
            {
                db.DocumentsModels.Add(documentsModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(documentsModels);
        }

        // GET: DocumentsModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocumentsModels documentsModels = db.DocumentsModels.Find(id);
            if (documentsModels == null)
            {
                return HttpNotFound();
            }
            return View(documentsModels);
        }

        // POST: DocumentsModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DocumentNumber,InvoiceNumber,DocumentDate,Price,RecordDate,Proveedor")] DocumentsModels documentsModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(documentsModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(documentsModels);
        }

        // GET: DocumentsModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocumentsModels documentsModels = db.DocumentsModels.Find(id);
            if (documentsModels == null)
            {
                return HttpNotFound();
            }
            return View(documentsModels);
        }

        // POST: DocumentsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DocumentsModels documentsModels = db.DocumentsModels.Find(id);
            db.DocumentsModels.Remove(documentsModels);
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
