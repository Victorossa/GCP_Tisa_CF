using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GCP_CF.Models;

namespace GCP_CF.Controllers
{
    public class EstadosFasesController : Controller
    {
        private GCPContext db = new GCPContext();

        // GET: EstadosFases
        public ActionResult Index()
        {
            return View(db.EstadosFases.ToList());
        }

        // GET: EstadosFases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadosFases estadosFases = db.EstadosFases.Find(id);
            if (estadosFases == null)
            {
                return HttpNotFound();
            }
            return View(estadosFases);
        }

        // GET: EstadosFases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadosFases/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Estado_Id,Descripcion")] EstadosFases estadosFases)
        {
            if (ModelState.IsValid)
            {
                db.EstadosFases.Add(estadosFases);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estadosFases);
        }

        // GET: EstadosFases/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadosFases estadosFases = db.EstadosFases.Find(id);
            if (estadosFases == null)
            {
                return HttpNotFound();
            }
            return View(estadosFases);
        }

        // POST: EstadosFases/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Estado_Id,Descripcion")] EstadosFases estadosFases)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estadosFases).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estadosFases);
        }

        // GET: EstadosFases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadosFases estadosFases = db.EstadosFases.Find(id);
            if (estadosFases == null)
            {
                return HttpNotFound();
            }
            return View(estadosFases);
        }

        // POST: EstadosFases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EstadosFases estadosFases = db.EstadosFases.Find(id);
            db.EstadosFases.Remove(estadosFases);
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
