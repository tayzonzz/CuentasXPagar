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
    public class AccountingStatementsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AccountingStatements
        public ActionResult Index()
        {
            return View(db.AccountingStatements.ToList());
        }

        // GET: AccountingStatements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountingStatements accountingStatements = db.AccountingStatements.Find(id);
            if (accountingStatements == null)
            {
                return HttpNotFound();
            }
            return View(accountingStatements);
        }

        // GET: AccountingStatements/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountingStatements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description,InventoryID,Account,TypeOfMovement,EntryDate,Ammount,State")] AccountingStatements accountingStatements)
        {
            if (ModelState.IsValid)
            {
                db.AccountingStatements.Add(accountingStatements);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accountingStatements);
        }

        // GET: AccountingStatements/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountingStatements accountingStatements = db.AccountingStatements.Find(id);
            if (accountingStatements == null)
            {
                return HttpNotFound();
            }
            return View(accountingStatements);
        }

        // POST: AccountingStatements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,InventoryID,Account,TypeOfMovement,EntryDate,Ammount,State")] AccountingStatements accountingStatements)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accountingStatements).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accountingStatements);
        }

        // GET: AccountingStatements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountingStatements accountingStatements = db.AccountingStatements.Find(id);
            if (accountingStatements == null)
            {
                return HttpNotFound();
            }
            return View(accountingStatements);
        }

        // POST: AccountingStatements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AccountingStatements accountingStatements = db.AccountingStatements.Find(id);
            db.AccountingStatements.Remove(accountingStatements);
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
