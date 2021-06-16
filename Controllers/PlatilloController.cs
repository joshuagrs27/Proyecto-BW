using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class PlatilloController : Controller
    {
        private TablasDBContext db = new TablasDBContext();

        // GET: Platillo
        public ActionResult Index()
        {
            return View(db.Platillo.ToList());
        }

        // GET: Platillo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Platillo platillo = db.Platillo.Find(id);
            if (platillo == null)
            {
                return HttpNotFound();
            }
            return View(platillo);
        }

        // GET: Platillo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Platillo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idPlatillo,nombre,sabor,precio,idRestaurante,idTurista")] Platillo platillo)
        {
            if (ModelState.IsValid)
            {
                db.Platillo.Add(platillo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(platillo);
        }

        // GET: Platillo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Platillo platillo = db.Platillo.Find(id);
            if (platillo == null)
            {
                return HttpNotFound();
            }
            return View(platillo);
        }

        // POST: Platillo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idPlatillo,nombre,sabor,precio,idRestaurante,idTurista")] Platillo platillo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(platillo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(platillo);
        }

        // GET: Platillo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Platillo platillo = db.Platillo.Find(id);
            if (platillo == null)
            {
                return HttpNotFound();
            }
            return View(platillo);
        }

        // POST: Platillo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Platillo platillo = db.Platillo.Find(id);
            db.Platillo.Remove(platillo);
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
