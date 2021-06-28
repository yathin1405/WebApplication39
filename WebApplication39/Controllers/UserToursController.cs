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
    public class UserToursController : Controller
    {
        private WebApplication39Context db = new WebApplication39Context();

        // GET: UserTours
        public ActionResult Index()
        {
            return View(db.UserTours.ToList());
        }
        public ActionResult UshakaBooking()
        {
            var tours = from e in db.Tours
                        orderby e.Tour_Type
                        where e.Tour_Type == Tour.Tours.Ushaka
                        select e;
            return View(tours);
        }

        public ActionResult GoodHopeBooking()
        {
            var tours = from e in db.Tours
                        orderby e.Tour_Type
                        where e.Tour_Type == Tour.Tours.Cape_Of_Good_Hope
                        select e;
            return View(tours);
        }

        public ActionResult ApartheidBooking()
        {
            var tours = from e in db.Tours
                        orderby e.Tour_Type
                        where e.Tour_Type == Tour.Tours.Apartheid_Museum
                        select e;
            return View(tours);
        }
        public ActionResult GoldReefBooking()
        {
            var tours = from e in db.Tours
                        orderby e.Tour_Type
                        where e.Tour_Type == Tour.Tours.Gold_Reef_City_Theme_Park
                        select e;
            return View(tours);
        }
        public ActionResult DNSBooking()
        {
            var tours = from e in db.Tours
                        orderby e.Tour_Type
                        where e.Tour_Type == Tour.Tours.Durban_Natural_Science_Museum
                        select e;
            return View(tours);
        }

        // GET: UserTours/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserTour userTour = db.UserTours.Find(id);
            if (userTour == null)
            {
                return HttpNotFound();
            }
            return View(userTour);
        }

        // GET: UserTours/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserTours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GuestID,TourType,Num_Adults,Num_Kids,Email,Tour_Name,Deposit,Discount,Total_Tickets,Total_Cost,GuestCost,Tour_Cost")] UserTour userTour)
        {
            if (ModelState.IsValid)
            {
                userTour.Discount = userTour.discount();
                userTour.Deposit = userTour.deposit();
                userTour.Total_Tickets = userTour.numOfTickets();
                //userTour.GuestCost = userTour.Guest_Cost();
                userTour.Tour_Cost = userTour.TourCost();
                userTour.Total_Cost = userTour.TotalCost();
                db.UserTours.Add(userTour);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userTour);
        }

        // GET: UserTours/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserTour userTour = db.UserTours.Find(id);
            if (userTour == null)
            {
                return HttpNotFound();
            }
            return View(userTour);
        }

        // POST: UserTours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GuestID,TourType,Num_Adults,Num_Kids,Email,Tour_Name,Deposit,Discount,Total_Tickets,Total_Cost,GuestCost,Tour_Cost")] UserTour userTour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userTour).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userTour);
        }

        // GET: UserTours/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserTour userTour = db.UserTours.Find(id);
            if (userTour == null)
            {
                return HttpNotFound();
            }
            return View(userTour);
        }

        // POST: UserTours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserTour userTour = db.UserTours.Find(id);
            db.UserTours.Remove(userTour);
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
