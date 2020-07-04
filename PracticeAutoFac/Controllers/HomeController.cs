using PracticeAutoFac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeAutoFac.Controllers
{
    public class HomeController : Controller
    {
        private readonly Person person;

        // See: https://www.youtube.com/watch?v=lucjChMhTWA
        // Also, notice I added a unit test for this.
        public HomeController(Person person)
        {
            this.person = person;
        }

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
    }
}