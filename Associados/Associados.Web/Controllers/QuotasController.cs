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
    public class QuotasController : Controller
    {
        private QuotaRepository db = new QuotaRepository();

        // GET: Quotas
        public ActionResult Index()
        {
            return View(db.List());
        }

        // GET: Quotas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quota quota = db.findById(Convert.ToInt32(id));
            if (quota == null)
            {
                return HttpNotFound();
            }
            return View(quota);
        }

        // GET: Quotas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quotas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Pagamento")] Quota quota)
        {
            if (ModelState.IsValid)
            {
                db.Add(quota);
                return RedirectToAction("Index");
            }

            return View(quota);
        }

        // GET: Quotas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quota quota = db.findById(Convert.ToInt32(id));
            if (quota == null)
            {
                return HttpNotFound();
            }
            return View(quota);
        }

        // POST: Quotas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Pagamento")] Quota quota)
        {
            if (ModelState.IsValid)
            {
                db.Edit(quota);
                return RedirectToAction("Index");
            }
            return View(quota);
        }

        // GET: Quotas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quota quota = db.findById(Convert.ToInt32(id));
            if (quota == null)
            {
                return HttpNotFound();
            }
            return View(quota);
        }

        // POST: Quotas/Delete/5
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
             //   db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
