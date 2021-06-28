using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication39.Data;
using WebApplication39.Models;

namespace WebApplication39.Controllers
{
    public class UserFlightsController : Controller
    {
        private WebApplication39Context db = new WebApplication39Context();

        // GET: UserFlights
        public ActionResult Index()
        {

            return View(db.UserFlights.ToList());
        }

        public ActionResult Invoice()
        {

            return View();
        }


        // GET: UserFlights/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserFlight userFlight = db.UserFlights.Find(id);
            if (userFlight == null)
            {
                return HttpNotFound();
            }
            return View(userFlight);
        }

        // GET: UserFlights/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserFlights/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,Airways,FROM,TO,SeatType,NumAdults,NumAChild,Departure_Date,DepartureTime,Return_Flight,Return_Date,Return_Time,Airline_Fee,Ticket_Price,passenger_Cost")] UserFlight userFlight)
        {
            if (ModelState.IsValid)
            {
                userFlight.Airline_Fee = userFlight.AirlineFee();
                userFlight.passenger_Cost = userFlight.passengerCost();
                userFlight.Ticket_Price = userFlight.ReturnTicketPrice();
                userFlight.Seat_Type_Calc = userFlight.SeatTypeCalc();

                db.UserFlights.Add(userFlight);
                db.SaveChanges();
                return RedirectToAction("Invoice");
            }

            return View(userFlight);
        }

        // GET: UserFlights/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserFlight userFlight = db.UserFlights.Find(id);
            if (userFlight == null)
            {
                return HttpNotFound();
            }
            return View(userFlight);
        }

        // POST: UserFlights/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,Airways,FROM,TO,SeatType,NumAdults,NumAChild,Departure_Date,DepartureTime,Return_Flight,Return_Date,Return_Time,Airline_Fee,Ticket_Price,passenger_Cost")] UserFlight userFlight)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userFlight).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userFlight);
        }

        // GET: UserFlights/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserFlight userFlight = db.UserFlights.Find(id);
            if (userFlight == null)
            {
                return HttpNotFound();
            }
            return View(userFlight);
        }

        // POST: UserFlights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserFlight userFlight = db.UserFlights.Find(id);
            db.UserFlights.Remove(userFlight);
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
