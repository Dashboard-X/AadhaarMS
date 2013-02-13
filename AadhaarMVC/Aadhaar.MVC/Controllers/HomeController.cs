using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aadhaar.MVC.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to Custom Permissions based Security System Demo!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
