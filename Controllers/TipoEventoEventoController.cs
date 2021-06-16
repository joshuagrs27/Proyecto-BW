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
    public class TipoEventoEventoController : Controller
    {
        private TablasDBContext db = new TablasDBContext();

        // GET: TipoEventoEvento
        public ActionResult Index()
        {
            return View(db.TipoEventoEvento.ToList());
        }

        // GET: TipoEventoEvento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEventoEvento tipoEventoEvento = db.TipoEventoEvento.Find(id);
            if (tipoEventoEvento == null)
            {
                return HttpNotFound();
            }
            return View(tipoEventoEvento);
        }

        // GET: TipoEventoEvento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoEventoEvento/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTipoEventoEvento,idEvento,idTipoEvento")] TipoEventoEvento tipoEventoEvento)
        {
            if (ModelState.IsValid)
            {
                db.TipoEventoEvento.Add(tipoEventoEvento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoEventoEvento);
        }

        // GET: TipoEventoEvento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEventoEvento tipoEventoEvento = db.TipoEventoEvento.Find(id);
            if (tipoEventoEvento == null)
            {
                return HttpNotFound();
            }
            return View(tipoEventoEvento);
        }

        // POST: TipoEventoEvento/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTipoEventoEvento,idEvento,idTipoEvento")] TipoEventoEvento tipoEventoEvento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoEventoEvento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoEventoEvento);
        }

        // GET: TipoEventoEvento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEventoEvento tipoEventoEvento = db.TipoEventoEvento.Find(id);
            if (tipoEventoEvento == null)
            {
                return HttpNotFound();
            }
            return View(tipoEventoEvento);
        }

        // POST: TipoEventoEvento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoEventoEvento tipoEventoEvento = db.TipoEventoEvento.Find(id);
            db.TipoEventoEvento.Remove(tipoEventoEvento);
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
