using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLHelper.Models;

namespace HTMLHelper.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            Models.Car car = new Models.Car();
            car.company = "Honda";
            car.model = "Civic";
            car.color = "Red";

            return View(car);
        }
    }
}