using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeightTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Regrister\n Username\n Name\n Age\n Gender\n Height\n Weight\n";

            return View();
        }
         
        public ActionResult About()
        {
            ViewBag.Message = "This app allows you to keep track of your weight and the path of the weight that you want to be.";

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