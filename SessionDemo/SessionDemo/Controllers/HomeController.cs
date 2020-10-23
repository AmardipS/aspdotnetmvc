using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Session is a property of Controller class whose type is HttpSessionStateBase.
            // Session is also used to pass data within the ASP.NET MVC application and unlike TempData
            // It persist for its expiration time (default time is 20 minutes but it can be increase, from Web.config file)
            // Session is valid for all requests, not for a single redirect like TempData.
            // It also requires typecasting for data and check for null balue to avoid error.
            // Session has a performance drawback because it slow down the application tha's why it is not recommended to 
                // always use session, must be used according to the situation.

            ViewData["Message"] = "Message from ViewData";
            ViewBag.Message = "Message from ViewBag";
            TempData["Message"] = "Message from TempData";
            Session["Message"] = "Message from Session";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}