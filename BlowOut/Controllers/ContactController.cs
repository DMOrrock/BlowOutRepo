using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.outputString = "Please call Support at <strong><u>801-555-1212</u></strong>. Thank you!";
            return View();
        }

        public ActionResult Email(string name, string email)
        {
            ViewBag.EmailOutput = "Thank you " + name + ". We will send you an email shortly to the address: " + email;
            return View();
        }
    }
}