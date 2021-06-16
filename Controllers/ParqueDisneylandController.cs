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
    public class ParqueDisneylandController : Controller
    {
        private TablasDBContext db = new TablasDBContext();

        // GET: ParqueDisneyland
        public ActionResult Index()
        {
            return View(db.ParqueDisneyland.ToList());
        }

        // GET: ParqueDisneyland/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParqueDisneyland parqueDisneyland = db.ParqueDisneyland.Find(id);
            if (parqueDisneyland == null)
            {
                return HttpNotFound();
            }
            return View(parqueDisneyland);
        }

        // GET: ParqueDisneyland/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParqueDisneyland/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idDisneyland,nombre,pais,telefono,idHorario,idEstado")] ParqueDisneyland parqueDisneyland)
        {
            if (ModelState.IsValid)
            {
                db.ParqueDisneyland.Add(parqueDisneyland);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parqueDisneyland);
        }

        // GET: ParqueDisneyland/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParqueDisneyland parqueDisneyland = db.ParqueDisneyland.Find(id);
            if (parqueDisneyland == null)
            {
                return HttpNotFound();
            }
            return View(parqueDisneyland);
        }

        // POST: ParqueDisneyland/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idDisneyland,nombre,pais,telefono,idHorario,idEstado")] ParqueDisneyland parqueDisneyland)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parqueDisneyland).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parqueDisneyland);
        }

        // GET: ParqueDisneyland/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParqueDisneyland parqueDisneyland = db.ParqueDisneyland.Find(id);
            if (parqueDisneyland == null)
            {
                return HttpNotFound();
            }
            return View(parqueDisneyland);
        }

        // POST: ParqueDisneyland/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ParqueDisneyland parqueDisneyland = db.ParqueDisneyland.Find(id);
            db.ParqueDisneyland.Remove(parqueDisneyland);
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
