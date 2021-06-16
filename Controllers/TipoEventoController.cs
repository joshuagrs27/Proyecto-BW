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
    public class TipoEventoController : Controller
    {
        private TablasDBContext db = new TablasDBContext();

        // GET: TipoEvento
        public ActionResult Index()
        {
            return View(db.TipoEvento.ToList());
        }

        // GET: TipoEvento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEvento tipoEvento = db.TipoEvento.Find(id);
            if (tipoEvento == null)
            {
                return HttpNotFound();
            }
            return View(tipoEvento);
        }

        // GET: TipoEvento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoEvento/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTipoEvento,nombre,duracionDias,clasificacion")] TipoEvento tipoEvento)
        {
            if (ModelState.IsValid)
            {
                db.TipoEvento.Add(tipoEvento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoEvento);
        }

        // GET: TipoEvento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEvento tipoEvento = db.TipoEvento.Find(id);
            if (tipoEvento == null)
            {
                return HttpNotFound();
            }
            return View(tipoEvento);
        }

        // POST: TipoEvento/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTipoEvento,nombre,duracionDias,clasificacion")] TipoEvento tipoEvento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoEvento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoEvento);
        }

        // GET: TipoEvento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEvento tipoEvento = db.TipoEvento.Find(id);
            if (tipoEvento == null)
            {
                return HttpNotFound();
            }
            return View(tipoEvento);
        }

        // POST: TipoEvento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoEvento tipoEvento = db.TipoEvento.Find(id);
            db.TipoEvento.Remove(tipoEvento);
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
