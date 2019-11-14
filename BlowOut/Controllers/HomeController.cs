using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class HomeController : Controller
    {
        public static Dictionary<string, int> newDict = new Dictionary<string, int>
        {
            {"Trumpet",55},
            {"Trombone",60},
            {"Tuba",70},
            {"Flute",45},
            {"Clarinet",35},
            {"Saxophone",42}
        };

        public static Dictionary<string, int> usedDict = new Dictionary<string, int>
        {
            {"Trumpet",25},
            {"Trombone",35},
            {"Tuba",50},
            {"Flute",25},
            {"Clarinet",27},
            {"Saxophone",30}
        };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Rentals()
        {
            return View();
        }

        public ActionResult UsedRentals()
        {
            ViewBag.displayDictionary = usedDict;
            return View();
        }

        public ActionResult NewRentals()
        {
            ViewBag.displayDictionary = newDict;
            return View();
        }
    }
}