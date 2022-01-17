using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjektAplikacija.Data;
using ProjektAplikacija.Models;

namespace ProjektAplikacija.Controllers
{
    public class filmovisController : Controller
    {
        private ProjektAplikacijaContext db = new ProjektAplikacijaContext();

        // GET: filmovis
        public ActionResult Index()
        {
            return View(db.filmovis.ToList());
        }

        // GET: filmovis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            filmovi filmovi = db.filmovis.Find(id);
            if (filmovi == null)
            {
                return HttpNotFound();
            }
            return View(filmovi);
        }

        // GET: filmovis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: filmovis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Naziv,Zanr")] filmovi filmovi)
        {
            if (ModelState.IsValid)
            {
                db.filmovis.Add(filmovi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(filmovi);
        }

        // GET: filmovis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            filmovi filmovi = db.filmovis.Find(id);
            if (filmovi == null)
            {
                return HttpNotFound();
            }
            return View(filmovi);
        }

        // POST: filmovis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Naziv,Zanr")] filmovi filmovi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filmovi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(filmovi);
        }

        // GET: filmovis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            filmovi filmovi = db.filmovis.Find(id);
            if (filmovi == null)
            {
                return HttpNotFound();
            }
            return View(filmovi);
        }

        // POST: filmovis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            filmovi filmovi = db.filmovis.Find(id);
            db.filmovis.Remove(filmovi);
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
