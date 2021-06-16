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
    public class TuristaParqueDisneylandController : Controller
    {
        private TablasDBContext db = new TablasDBContext();

        // GET: TuristaParqueDisneyland
        public ActionResult Index()
        {
            return View(db.TuristaParqueDisneyland.ToList());
        }

        // GET: TuristaParqueDisneyland/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TuristaParqueDisneyland turistaParqueDisneyland = db.TuristaParqueDisneyland.Find(id);
            if (turistaParqueDisneyland == null)
            {
                return HttpNotFound();
            }
            return View(turistaParqueDisneyland);
        }

        // GET: TuristaParqueDisneyland/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TuristaParqueDisneyland/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTuristaParqueDisneyland,idTurista,idDisneyland")] TuristaParqueDisneyland turistaParqueDisneyland)
        {
            if (ModelState.IsValid)
            {
                db.TuristaParqueDisneyland.Add(turistaParqueDisneyland);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(turistaParqueDisneyland);
        }

        // GET: TuristaParqueDisneyland/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TuristaParqueDisneyland turistaParqueDisneyland = db.TuristaParqueDisneyland.Find(id);
            if (turistaParqueDisneyland == null)
            {
                return HttpNotFound();
            }
            return View(turistaParqueDisneyland);
        }

        // POST: TuristaParqueDisneyland/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTuristaParqueDisneyland,idTurista,idDisneyland")] TuristaParqueDisneyland turistaParqueDisneyland)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turistaParqueDisneyland).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(turistaParqueDisneyland);
        }

        // GET: TuristaParqueDisneyland/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TuristaParqueDisneyland turistaParqueDisneyland = db.TuristaParqueDisneyland.Find(id);
            if (turistaParqueDisneyland == null)
            {
                return HttpNotFound();
            }
            return View(turistaParqueDisneyland);
        }

        // POST: TuristaParqueDisneyland/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TuristaParqueDisneyland turistaParqueDisneyland = db.TuristaParqueDisneyland.Find(id);
            db.TuristaParqueDisneyland.Remove(turistaParqueDisneyland);
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
