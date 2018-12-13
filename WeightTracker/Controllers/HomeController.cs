using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeightTracker.Controllers
{
    public class HomeController : Controller
    {
    int calories, mileages, pace;
        public void test()
        {
            Console.WriteLine(pace);
        }
        public ActionResult Index()
        {
            ViewBag.Message = "Regrister\n Username\n Name\n Age\n Gender\n Height\n Weight\n" + pace;
            pace = calories - mileages;
            return View();
        }
         
        public ActionResult About()
        {
            ViewBag.Message = "This app allows users to keep track of your weight, mileage, and the path to prefered weight." + pace;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Tracker()
        {
            ViewBag.Message = DateTime.Now.ToLongDateString();

            return View();
        }
        public ActionResult Result()
        {
            ViewBag.Message = "Results";

            return View();
        }
        public string[] makeitmeal = new string[3];
        public void meal()
        {
            makeitmeal = new string[] { "Foods", "Meals", "Categories" };
        }

    }
}