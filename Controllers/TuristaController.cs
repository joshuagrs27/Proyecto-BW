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
    public class TuristaController : Controller
    {
        private TablasDBContext db = new TablasDBContext();

        // GET: Turista
        public ActionResult Index()
        {
            return View(db.Turista.ToList());
        }

        // GET: Turista/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turista turista = db.Turista.Find(id);
            if (turista == null)
            {
                return HttpNotFound();
            }
            return View(turista);
        }

        // GET: Turista/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Turista/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTurista,nombres,apellidoPaterno,apellidoMaterno,telefono,genero,nacionalidad")] Turista turista)
        {
            if (ModelState.IsValid)
            {
                db.Turista.Add(turista);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(turista);
        }

        // GET: Turista/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turista turista = db.Turista.Find(id);
            if (turista == null)
            {
                return HttpNotFound();
            }
            return View(turista);
        }

        // POST: Turista/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTurista,nombres,apellidoPaterno,apellidoMaterno,telefono,genero,nacionalidad")] Turista turista)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turista).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(turista);
        }

        // GET: Turista/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turista turista = db.Turista.Find(id);
            if (turista == null)
            {
                return HttpNotFound();
            }
            return View(turista);
        }

        // POST: Turista/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Turista turista = db.Turista.Find(id);
            db.Turista.Remove(turista);
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
