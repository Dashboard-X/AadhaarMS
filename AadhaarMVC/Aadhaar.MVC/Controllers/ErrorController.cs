using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aadhaar.MVC.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/

        public ActionResult Index(string aspxerrorpath)
        {
            TempData["message"] = "The Location:"+aspxerrorpath+" is not accessible from this User Account due to security restrictions.";
            return View();
        }

    }
}
