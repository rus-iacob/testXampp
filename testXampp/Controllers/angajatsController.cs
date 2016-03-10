using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using testXampp;

namespace testXampp.Controllers
{
    public class angajatsController : Controller
    {
        private autoserviceprojectEntities db = new autoserviceprojectEntities();

        // GET: angajats
        public ActionResult Index()
        {
            var angajats = db.angajats.Include(a => a.salar);
            return View(angajats.ToList());
        }

        // GET: angajats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            angajat angajat = db.angajats.Find(id);
            if (angajat == null)
            {
                return HttpNotFound();
            }
            return View(angajat);
        }

        // GET: angajats/Create
        public ActionResult Create()
        {
            ViewBag.id = new SelectList(db.salars, "angajat_id", "angajat_id");
            return View();
        }

        // POST: angajats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nume,data_angajarii,experienta")] angajat angajat)
        {
            if (ModelState.IsValid)
            {
                db.angajats.Add(angajat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id = new SelectList(db.salars, "angajat_id", "angajat_id", angajat.id);
            return View(angajat);
        }

        // GET: angajats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            angajat angajat = db.angajats.Find(id);
            if (angajat == null)
            {
                return HttpNotFound();
            }
            ViewBag.id = new SelectList(db.salars, "angajat_id", "angajat_id", angajat.id);
            return View(angajat);
        }

        // POST: angajats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nume,data_angajarii,experienta")] angajat angajat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(angajat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id = new SelectList(db.salars, "angajat_id", "angajat_id", angajat.id);
            return View(angajat);
        }

        // GET: angajats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            angajat angajat = db.angajats.Find(id);
            if (angajat == null)
            {
                return HttpNotFound();
            }
            return View(angajat);
        }

        // POST: angajats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            angajat angajat = db.angajats.Find(id);
            db.angajats.Remove(angajat);
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
