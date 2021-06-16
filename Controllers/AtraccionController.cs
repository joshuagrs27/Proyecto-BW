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
    public class AtraccionController : Controller
    {
        private TablasDBContext db = new TablasDBContext();

        // GET: Atraccion
        public ActionResult Index()
        {
            return View(db.Atraccion.ToList());
        }

        // GET: Atraccion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Atraccion atraccion = db.Atraccion.Find(id);
            if (atraccion == null)
            {
                return HttpNotFound();
            }
            return View(atraccion);
        }

        // GET: Atraccion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Atraccion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idAtraccion,nombre,horaApertura,horaCierre,precio,idDisneyland")] Atraccion atraccion)
        {
            if (ModelState.IsValid)
            {
                db.Atraccion.Add(atraccion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(atraccion);
        }

        // GET: Atraccion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Atraccion atraccion = db.Atraccion.Find(id);
            if (atraccion == null)
            {
                return HttpNotFound();
            }
            return View(atraccion);
        }

        // POST: Atraccion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idAtraccion,nombre,horaApertura,horaCierre,precio,idDisneyland")] Atraccion atraccion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(atraccion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(atraccion);
        }

        // GET: Atraccion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Atraccion atraccion = db.Atraccion.Find(id);
            if (atraccion == null)
            {
                return HttpNotFound();
            }
            return View(atraccion);
        }

        // POST: Atraccion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Atraccion atraccion = db.Atraccion.Find(id);
            db.Atraccion.Remove(atraccion);
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
