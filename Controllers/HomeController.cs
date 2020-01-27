using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mg118115MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My Biography.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Matt Gilligan's contact page.";

            return View();
        }
    }
}