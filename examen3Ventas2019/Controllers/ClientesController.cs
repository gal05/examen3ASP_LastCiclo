using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using examen3Ventas2019;

namespace examen3Ventas2019.Controllers
{
    public class ClientesController : Controller
    {
        private VENTAS2019Entities db = new VENTAS2019Entities();

        // GET: Clientes
        public ActionResult Index()
        {
            var cLIENTE = db.CLIENTE.Include(c => c.DISTRITO);
            return View(cLIENTE.ToList());
        }

        // GET: Clientes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENTE cLIENTE = db.CLIENTE.Find(id);
            if (cLIENTE == null)
            {
                return HttpNotFound();
            }
            return View(cLIENTE);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            ViewBag.COD_DIST = new SelectList(db.DISTRITO, "COD_DIST", "DESCRIP_DIST");
            return View();
        }

        // POST: Clientes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "COD_CLI,NOMBRES,APE_PATER_CLI,APE_MATER_CLI,DIRECCION_CLI,TELEFONO_CLI,COD_DIST,CORREO_E")] CLIENTE cLIENTE)
        {
            if (ModelState.IsValid)
            {
                db.CLIENTE.Add(cLIENTE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.COD_DIST = new SelectList(db.DISTRITO, "COD_DIST", "DESCRIP_DIST", cLIENTE.COD_DIST);
            return View(cLIENTE);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENTE cLIENTE = db.CLIENTE.Find(id);
            if (cLIENTE == null)
            {
                return HttpNotFound();
            }
            ViewBag.COD_DIST = new SelectList(db.DISTRITO, "COD_DIST", "DESCRIP_DIST", cLIENTE.COD_DIST);
            return View(cLIENTE);
        }

        // POST: Clientes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "COD_CLI,NOMBRES,APE_PATER_CLI,APE_MATER_CLI,DIRECCION_CLI,TELEFONO_CLI,COD_DIST,CORREO_E")] CLIENTE cLIENTE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cLIENTE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.COD_DIST = new SelectList(db.DISTRITO, "COD_DIST", "DESCRIP_DIST", cLIENTE.COD_DIST);
            return View(cLIENTE);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENTE cLIENTE = db.CLIENTE.Find(id);
            if (cLIENTE == null)
            {
                return HttpNotFound();
            }
            return View(cLIENTE);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CLIENTE cLIENTE = db.CLIENTE.Find(id);
            db.CLIENTE.Remove(cLIENTE);
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
