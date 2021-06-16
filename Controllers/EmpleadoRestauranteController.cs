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
    public class EmpleadoRestauranteController : Controller
    {
        private TablasDBContext db = new TablasDBContext();

        // GET: EmpleadoRestaurante
        public ActionResult Index()
        {
            return View(db.EmpleadoRestaurante.ToList());
        }

        // GET: EmpleadoRestaurante/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadoRestaurante empleadoRestaurante = db.EmpleadoRestaurante.Find(id);
            if (empleadoRestaurante == null)
            {
                return HttpNotFound();
            }
            return View(empleadoRestaurante);
        }

        // GET: EmpleadoRestaurante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadoRestaurante/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idEmpleadoRestaurante,nombres,apellidoPaterno,apellidoMaterno,idRestaurante")] EmpleadoRestaurante empleadoRestaurante)
        {
            if (ModelState.IsValid)
            {
                db.EmpleadoRestaurante.Add(empleadoRestaurante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empleadoRestaurante);
        }

        // GET: EmpleadoRestaurante/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadoRestaurante empleadoRestaurante = db.EmpleadoRestaurante.Find(id);
            if (empleadoRestaurante == null)
            {
                return HttpNotFound();
            }
            return View(empleadoRestaurante);
        }

        // POST: EmpleadoRestaurante/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idEmpleadoRestaurante,nombres,apellidoPaterno,apellidoMaterno,idRestaurante")] EmpleadoRestaurante empleadoRestaurante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empleadoRestaurante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleadoRestaurante);
        }

        // GET: EmpleadoRestaurante/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadoRestaurante empleadoRestaurante = db.EmpleadoRestaurante.Find(id);
            if (empleadoRestaurante == null)
            {
                return HttpNotFound();
            }
            return View(empleadoRestaurante);
        }

        // POST: EmpleadoRestaurante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmpleadoRestaurante empleadoRestaurante = db.EmpleadoRestaurante.Find(id);
            db.EmpleadoRestaurante.Remove(empleadoRestaurante);
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
