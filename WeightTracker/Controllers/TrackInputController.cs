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
    public class TrackInputController : Controller
    {
        List<int> DailyCalories, WeeklyCalories, MonthlyCalories, YearlyCalories, DailyMileage, WeeklyMileage, MonthlyMileage, YearlyMileage;
        private WeightTrackerDatabaseEntities db = new WeightTrackerDatabaseEntities();

        // GET: TrackInput
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult FoodInput()
        {
            return View();
        }
        // Create Daily, Weekly, Monthly, and Yearly Lists
        // Add selected drop down to list
        // Reveal hidden dropdown from selected drop down
        //
    }
}
