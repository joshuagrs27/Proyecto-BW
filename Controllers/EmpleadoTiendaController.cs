using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Models
{
    public class EmpleadoTiendaController : Controller
    {
        private TablasDBContext db = new TablasDBContext();

        // GET: EmpleadoTienda
        public ActionResult Index()
        {
            return View(db.EmpleadoTienda.ToList());
        }

        // GET: EmpleadoTienda/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadoTienda empleadoTienda = db.EmpleadoTienda.Find(id);
            if (empleadoTienda == null)
            {
                return HttpNotFound();
            }
            return View(empleadoTienda);
        }

        // GET: EmpleadoTienda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadoTienda/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idEmpleadoTienda,nombres,apellidoPaterno,apellidoMaterno,idTienda")] EmpleadoTienda empleadoTienda)
        {
            if (ModelState.IsValid)
            {
                db.EmpleadoTienda.Add(empleadoTienda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empleadoTienda);
        }

        // GET: EmpleadoTienda/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadoTienda empleadoTienda = db.EmpleadoTienda.Find(id);
            if (empleadoTienda == null)
            {
                return HttpNotFound();
            }
            return View(empleadoTienda);
        }

        // POST: EmpleadoTienda/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idEmpleadoTienda,nombres,apellidoPaterno,apellidoMaterno,idTienda")] EmpleadoTienda empleadoTienda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empleadoTienda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleadoTienda);
        }

        // GET: EmpleadoTienda/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadoTienda empleadoTienda = db.EmpleadoTienda.Find(id);
            if (empleadoTienda == null)
            {
                return HttpNotFound();
            }
            return View(empleadoTienda);
        }

        // POST: EmpleadoTienda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmpleadoTienda empleadoTienda = db.EmpleadoTienda.Find(id);
            db.EmpleadoTienda.Remove(empleadoTienda);
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
