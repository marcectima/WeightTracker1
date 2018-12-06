using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WeightTracker.Models;

namespace WeightTracker.Controllers
{
    public class FoodIntakesController : Controller
    {
        private WeightTrackerDatabaseEntities db = new WeightTrackerDatabaseEntities();

        // GET: FoodIntakes
        public ActionResult Index()
        {
            return View(db.FoodIntakes.ToList());
        }

        // GET: FoodIntakes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodIntake foodIntake = db.FoodIntakes.Find(id);
            if (foodIntake == null)
            {
                return HttpNotFound();
            }
            return View(foodIntake);
        }

        // GET: FoodIntakes/Create
        public ActionResult Create()
        {
            ViewBag.Food = new SelectList(db.FoodIntakes, "Food", "FoodType");
            return View();
        }

        // POST: FoodIntakes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Food,FoodType")] FoodIntake foodIntake )
        {
            if (ModelState.IsValid)
            {
                db.FoodIntakes.Add(foodIntake);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Food = new SelectList(db.FoodIntakes, "Food", "FoodType", foodIntake.Food);

            return View(foodIntake);
        }

        // GET: FoodIntakes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodIntake foodIntake = db.FoodIntakes.Find(id);
            if (foodIntake == null)
            {
                return HttpNotFound();
            }
            return View(foodIntake);
        }

        // POST: FoodIntakes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Food,FoodType")] FoodIntake foodIntake)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foodIntake).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(foodIntake);
        }

        // GET: FoodIntakes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodIntake foodIntake = db.FoodIntakes.Find(id);
            if (foodIntake == null)
            {
                return HttpNotFound();
            }
            return View(foodIntake);
        }

        // POST: FoodIntakes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FoodIntake foodIntake = db.FoodIntakes.Find(id);
            db.FoodIntakes.Remove(foodIntake);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MealsInput ()
        {
            return View();
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
