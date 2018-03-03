using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hotel_Surf.Models;

namespace Hotel_Surf.Controllers
{
    public class BungalowsController : Controller
    {
        private BungalowsEntities1 db = new BungalowsEntities1();

        // GET: Bungalows
        public ActionResult Index()
        {
            return View(db.Bungalows.ToList());
        }

        // GET: Bungalows/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bungalow bungalow = db.Bungalows.Find(id);
            if (bungalow == null)
            {
                return HttpNotFound();
            }
            return View(bungalow);
        }

        // GET: Bungalows/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bungalows/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumBung,TipBung,PrecoBung,Reservado,NumCamas,NumPessoas")] Bungalow bungalow)
        {
            if (ModelState.IsValid)
            {
                db.Bungalows.Add(bungalow);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bungalow);
        }

        // GET: Bungalows/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bungalow bungalow = db.Bungalows.Find(id);
            if (bungalow == null)
            {
                return HttpNotFound();
            }
            return View(bungalow);
        }

        // POST: Bungalows/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumBung,TipBung,PrecoBung,Reservado,NumCamas,NumPessoas")] Bungalow bungalow)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bungalow).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bungalow);
        }

        // GET: Bungalows/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bungalow bungalow = db.Bungalows.Find(id);
            if (bungalow == null)
            {
                return HttpNotFound();
            }
            return View(bungalow);
        }

        // POST: Bungalows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bungalow bungalow = db.Bungalows.Find(id);
            db.Bungalows.Remove(bungalow);
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
