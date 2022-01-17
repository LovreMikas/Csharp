using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ucenicici.Data;
using Ucenicici.Models;

namespace Ucenicici.Controllers
{
    public class Uceniks1Controller : Controller
    {
        private UceniciciContext db = new UceniciciContext();

        // GET: Uceniks1
        public ActionResult Index()
        {
            return View(db.Uceniks.ToList());
        }

        // GET: Uceniks1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ucenik ucenik = db.Uceniks.Find(id);
            if (ucenik == null)
            {
                return HttpNotFound();
            }
            return View(ucenik);
        }

        // GET: Uceniks1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Uceniks1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ime,prezime,razred,datum,stanje")] Ucenik ucenik)
        {
            if (ModelState.IsValid)
            {
                db.Uceniks.Add(ucenik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ucenik);
        }

        // GET: Uceniks1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ucenik ucenik = db.Uceniks.Find(id);
            if (ucenik == null)
            {
                return HttpNotFound();
            }
            return View(ucenik);
        }

        // POST: Uceniks1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,ime,prezime,razred,datum,stanje")] Ucenik ucenik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ucenik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ucenik);
        }

        // GET: Uceniks1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ucenik ucenik = db.Uceniks.Find(id);
            if (ucenik == null)
            {
                return HttpNotFound();
            }
            return View(ucenik);
        }

        // POST: Uceniks1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ucenik ucenik = db.Uceniks.Find(id);
            db.Uceniks.Remove(ucenik);
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
