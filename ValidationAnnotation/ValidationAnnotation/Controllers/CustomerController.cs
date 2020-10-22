using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidationAnnotation.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Models.Customer newCustomer = new Models.Customer();
            newCustomer.ID = 123;
            newCustomer.Name = "John Doe";
            newCustomer.Email = "123@gmail.com";

            return View("Index", newCustomer);
        }
    }
}