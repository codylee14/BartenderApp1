using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BartenderApp.Models;
using BartenderApp.ViewModels;

namespace BartenderApp.Controllers
{
    public class DrinksController : Controller
    {
        // GET: Drinks
        public ActionResult Random()
        {
            var drink = new Drinks() {Name = "Rum and Coke"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}

            };

            var viewModel = new RandomDrinksViewModel
            {
                Drinks = drink,
                Customer = customers

            };

            return View(viewModel);
            //ViewData["Drinks"] = drink;
            //ViewBag.Drinks = drink;
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model

            return View(drink);
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //drinks
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex = {0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("drinks/alcohol/mixer/{alcohol}/{mixer}")]
        public ActionResult AlcoholAndMixer(string alcohol, string mixer)
        {
            return Content(alcohol + "/" + mixer);
        }

    }
}