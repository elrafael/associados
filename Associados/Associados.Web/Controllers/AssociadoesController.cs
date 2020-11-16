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
    public class AssociadoesController : Controller
    {
        private AssociadoRepository db = new AssociadoRepository();

        // GET: Associadoes
        public ActionResult Index()
        {
            return View(db.List());
        }

        // GET: Associadoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Associado associado = db.findById(Convert.ToInt32(id));
            if (associado == null)
            {
                return HttpNotFound();
            }
            return View(associado);
        }

        // GET: Associadoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Associadoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Apelido,Email")] Associado associado)
        {
            if (ModelState.IsValid)
            {
                db.Add(associado);
                return RedirectToAction("Index");
            }

            return View(associado);
        }

        // GET: Associadoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Associado associado = db.findById(Convert.ToInt32(id));
            if (associado == null)
            {
                return HttpNotFound();
            }
            return View(associado);
        }

        // POST: Associadoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Apelido,Email")] Associado associado)
        {
            if (ModelState.IsValid)
            {
                db.Edit(associado);
                return RedirectToAction("Index");
            }
            return View(associado);
        }

        // GET: Associadoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Associado associado = db.findById(Convert.ToInt32(id));
            if (associado == null)
            {
                return HttpNotFound();
            }
            return View(associado);
        }

        // POST: Associadoes/Delete/5
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
