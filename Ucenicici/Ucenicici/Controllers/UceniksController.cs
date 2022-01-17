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
    

    public class UceniksController : Controller

    {
        private UceniciciContext db = new UceniciciContext();

        // GET: Uceniks
        public ActionResult Index()
        {
                List<Ucenik> stud = new List<Ucenik>
            {
                new Ucenik{id=1,ime="mijo",prezime="mati" ,razred="34" , datum=2002, stanje= "mater"},
                new Ucenik{id=1,ime="d",prezime="d" ,razred="34" , datum=2002, stanje= "caca"}

            };
                return View(db.Uceniks.ToList());
                ViewData.Model = stud;
                return View();
            }

        // GET: Uceniks/Details/5
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

        // GET: Uceniks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Uceniks/Create
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

        // GET: Uceniks/Edit/5
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

        // POST: Uceniks/Edit/5
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

        // GET: Uceniks/Delete/5
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

        // POST: Uceniks/Delete/5
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
