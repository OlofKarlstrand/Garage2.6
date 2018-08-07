using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Garage2._6.DataAccessLayer;
using Garage2._6.Models;

namespace Garage2._6.Models
{
    public class ParkedVehiclesController : Controller
    {
        private GarageContext db = new GarageContext();

        // GET: ParkedVehicles
        public ActionResult Index()
        {
            
            return View(db.ParkedVehicles.ToList());
        }

        public ActionResult Overview()
        {
            return View(db.ParkedVehicles.ToList());
        }


        // GET: ParkedVehicles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.ParkedVehicles.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Create
        public ActionResult Park()
        {
            var model = new ParkedViewModel()
            {
                Types = db.VehicleType,
                ListMembers = db.Members,
            };

            return View(model);
        }
        // POST: ParkedVehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Park([Bind(Include = "Id,RegNr,Description,Color,NumberofEngines,CheckIn,VehicleType,VehicleTypeId,MemberId")] ParkedVehicle parkedVehicle)
        {



            if (ModelState.IsValid)
            {

                var vehicle = new ParkedVehicle()

                {
                    //Id= parkedVehicle.Id,
                    RegNr = parkedVehicle.RegNr,
                    Description = parkedVehicle.Description,
                    Color = parkedVehicle.Color,
                    NumberofEngines = parkedVehicle.NumberofEngines,
                    CheckIn = DateTime.Now,
                    VehicleType = parkedVehicle.VehicleType,
                    VehicleTypeId = parkedVehicle.VehicleTypeId,
                    MemberId = parkedVehicle.MemberId,
                };


                db.ParkedVehicles.Add(vehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parkedVehicle);
        }


        // GET: ParkedVehicles/Delete/5
        [HttpGet]
        public ActionResult CheckOut(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("overview");
            }

            ParkedVehicle v = db.ParkedVehicles.Find(id);

            if (v == null)
            {
                return RedirectToAction("overview");
            }

            ReceiptViewModel parkedVehicle = new ReceiptViewModel(v.Id, v.RegNr, v.VehicleType, v.CheckIn, DateTime.Now);
            if (v == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);

        }

        // POST: ParkedVehicles/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]


        public ActionResult Receipt(int id)
        {
            ParkedVehicle v = db.ParkedVehicles.Find(id);

            if (v == null)
            {
                return HttpNotFound();
            }
            db.ParkedVehicles.Remove(v);
            db.SaveChanges();

            ReceiptViewModel info = new ReceiptViewModel(v.Id, v.RegNr, v.VehicleType, v.CheckIn, DateTime.Now);

            return View(info);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        [HttpPost]
        public ActionResult Search(string search)
        {

            var result = db.ParkedVehicles.Where(e => e.RegNr.Contains(search));// || db.VehicleType.Where(e => e.VehicleTypes.TypeName.e(search));

            return View("overview", result);
        }
        public ActionResult Front()
        {
            return View();
        }

    }
}
