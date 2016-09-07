using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BartenderApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ViewResult Index()

        {
            var customer = GetCustomer();

            return View(customer);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomer
        }
    }
}