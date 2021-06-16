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
    public class TiendaController : Controller
    {
        private TablasDBContext db = new TablasDBContext();

        // GET: Tienda
        public ActionResult Index()
        {
            return View(db.Tienda.ToList());
        }

        // GET: Tienda/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tienda tienda = db.Tienda.Find(id);
            if (tienda == null)
            {
                return HttpNotFound();
            }
            return View(tienda);
        }

        // GET: Tienda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tienda/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTienda,nombre,tipo,ubicacion,idDisneyland")] Tienda tienda)
        {
            if (ModelState.IsValid)
            {
                db.Tienda.Add(tienda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tienda);
        }

        // GET: Tienda/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tienda tienda = db.Tienda.Find(id);
            if (tienda == null)
            {
                return HttpNotFound();
            }
            return View(tienda);
        }

        // POST: Tienda/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTienda,nombre,tipo,ubicacion,idDisneyland")] Tienda tienda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tienda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tienda);
        }

        // GET: Tienda/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tienda tienda = db.Tienda.Find(id);
            if (tienda == null)
            {
                return HttpNotFound();
            }
            return View(tienda);
        }

        // POST: Tienda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tienda tienda = db.Tienda.Find(id);
            db.Tienda.Remove(tienda);
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
