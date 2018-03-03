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
    public class ReservasController : Controller
    {
        private BungalowsEntities1 db = new BungalowsEntities1();

        // GET: Reservas
        public ActionResult Index()
        {
            var reservas = db.Reservas.Include(r => r.Bungalow).Include(r => r.Cliente);
            return View(reservas.ToList());
        }

        // GET: Reservas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reserva reserva = db.Reservas.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        // GET: Reservas/Create
        public ActionResult Create()
        {
            ViewBag.NumBungRes = new SelectList(db.Bungalows, "NumBung", "NumBung");
            ViewBag.NumCliente = new SelectList(db.Clientes, "NumCliente", "NumCliente");
            return View();
        }

        // POST: Reservas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumReserva,NumCliente,DatEntrada,DatSaida,NumAdultos,NumCriancas,NumBungRes")] Reserva reserva)
        {
            var numClientes = db.Reservas.Where(c => c.NumBungRes == reserva.NumBungRes).Count();
            var numBung = Convert.ToInt32(Request.Form["NumBungRes"]);
            var maxPessoas = db.Bungalows.Where(b => b.NumBung == numBung).Select(n => n.NumPessoas).Single();
            if (numClientes < maxPessoas  && ModelState.IsValid)
                {
                    db.Reservas.Add(reserva);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Message = string.Format("Bungalow Cheio!");
                }

            ViewBag.NumBungRes = new SelectList(db.Bungalows, "NumBung", "NumBung", reserva.NumBungRes);
            ViewBag.NumCliente = new SelectList(db.Clientes, "NumCliente", "NumCliente", reserva.NumCliente);
            return View(reserva);
        }

        // GET: Reservas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reserva reserva = db.Reservas.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            ViewBag.NumBungRes = new SelectList(db.Bungalows, "NumBung", "NumBung", reserva.NumBungRes);
            ViewBag.NumCliente = new SelectList(db.Clientes, "NumCliente", "NumCliente", reserva.NumCliente);
            return View(reserva);
        }

        // POST: Reservas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumReserva,NumCliente,DatEntrada,DatSaida,NumAdultos,NumCriancas,NumBungRes")] Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reserva).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NumBungRes = new SelectList(db.Bungalows, "NumBung", "NumBung", reserva.NumBungRes);
            ViewBag.NumCliente = new SelectList(db.Clientes, "NumCliente", "NumCliente", reserva.NumCliente);
            return View(reserva);
        }

        // GET: Reservas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reserva reserva = db.Reservas.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        // POST: Reservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reserva reserva = db.Reservas.Find(id);
            db.Reservas.Remove(reserva);
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
