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
    public class TuristaHotelController : Controller
    {
        private TablasDBContext db = new TablasDBContext();

        // GET: TuristaHotel
        public ActionResult Index()
        {
            return View(db.TuristaHotel.ToList());
        }

        // GET: TuristaHotel/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TuristaHotel turistaHotel = db.TuristaHotel.Find(id);
            if (turistaHotel == null)
            {
                return HttpNotFound();
            }
            return View(turistaHotel);
        }

        // GET: TuristaHotel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TuristaHotel/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTuristaHotel,idTurista,idHotel")] TuristaHotel turistaHotel)
        {
            if (ModelState.IsValid)
            {
                db.TuristaHotel.Add(turistaHotel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(turistaHotel);
        }

        // GET: TuristaHotel/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TuristaHotel turistaHotel = db.TuristaHotel.Find(id);
            if (turistaHotel == null)
            {
                return HttpNotFound();
            }
            return View(turistaHotel);
        }

        // POST: TuristaHotel/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTuristaHotel,idTurista,idHotel")] TuristaHotel turistaHotel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turistaHotel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(turistaHotel);
        }

        // GET: TuristaHotel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TuristaHotel turistaHotel = db.TuristaHotel.Find(id);
            if (turistaHotel == null)
            {
                return HttpNotFound();
            }
            return View(turistaHotel);
        }

        // POST: TuristaHotel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TuristaHotel turistaHotel = db.TuristaHotel.Find(id);
            db.TuristaHotel.Remove(turistaHotel);
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
