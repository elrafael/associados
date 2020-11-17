using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Associados.Core;
using Associados.Data;

namespace Associados.Web.Controllers
{
    public class MoradasController : Controller
    {
        private MoradaRepository db = new MoradaRepository();

        // GET: Moradas
        public ActionResult Index()
        {
            return View(db.List());
        }

        // GET: Moradas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Morada morada = db.findById(Convert.ToInt32(id));
            if (morada == null)
            {
                return HttpNotFound();
            }
            return View(morada);
        }

        // GET: Moradas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Moradas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TipoVia,NomeVia,Porta,Andar,CodigoPostal")] Morada morada)
        {
            if (ModelState.IsValid)
            {
                db.Add(morada);
                return RedirectToAction("Index");
            }

            return View(morada);
        }

        // GET: Moradas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Morada morada = db.findById(Convert.ToInt32(id));
            if (morada == null)
            {
                return HttpNotFound();
            }
            return View(morada);
        }

        // POST: Moradas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TipoVia,NomeVia,Porta,Andar,CodigoPostal")] Morada morada)
        {
            if (ModelState.IsValid)
            {
                db.Edit(morada);
                return RedirectToAction("Index");
            }
            return View(morada);
        }

        // GET: Moradas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Morada morada = db.findById(Convert.ToInt32(id));
            if (morada == null)
            {
                return HttpNotFound();
            }
            return View(morada);
        }

        // POST: Moradas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            db.Remove(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
