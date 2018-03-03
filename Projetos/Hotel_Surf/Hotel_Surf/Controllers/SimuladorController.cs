using Hotel_Surf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Surf.Controllers
{
    public class SimuladorController : Controller
    {
        private BungalowsEntities1 db = new BungalowsEntities1();

        // GET: Simulador
        public JsonResult FetchBungalows() // its a GET, not a POST
        {
            var bungalows = db.Bungalows.Select(c => new
            {
                ID = c.NumBung,
                Text = c.TipBung
            });

            return Json(bungalows, JsonRequestBehavior.AllowGet);
        }

        public JsonResult FetchReservas() // its a GET, not a POST
        {
            db.Configuration.ProxyCreationEnabled = false;
            var reservas = db.Reservas.Select(d => new
            {
                ID = d.NumReserva,
                d.NumAdultos,
                d.NumCriancas,
                d.DatEntrada,
                d.DatSaida,
                d.NumCliente,
                d.NumBungRes,
                d.Bungalow
            });

            return Json(reservas, JsonRequestBehavior.AllowGet);
        }
        public JsonResult FetchReservasById(int id) // its a GET, not a POST
        {
            db.Configuration.ProxyCreationEnabled = false;
            var reservas = db.Reservas.Select(d => new
            {
                ID = d.NumReserva,
                d.NumAdultos,
                d.NumCriancas,
                d.DatEntrada,
                d.DatSaida,
                d.NumCliente,
                d.NumBungRes,
                d.Bungalow
            }).Where(x => x.ID == id);

            return Json(reservas, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index()
        {
            List<object> myDB = new List<object>();
            myDB.Add(db.Reservas.ToList());
            myDB.Add(db.Bungalows.ToList());
            return View(myDB);
        }


    }
}
