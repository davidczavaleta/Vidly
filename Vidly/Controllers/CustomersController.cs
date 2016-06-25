using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Santiago Cruz Perez" },
                new Customer {Id = 2, Name = "David Cruz Zavaleta" },
                new Customer {Id = 3, Name = "Cecilia Perez Morales" }
            };

            var customersViewModel = new CustomersListViewModel { Customers = customers };

            return View(customersViewModel);
        }

        [Route("customers/details/{id}")]
        public ActionResult CustomerByID(int id)
        {
            var customerName = "None";
            if (id == 1)
                customerName = "Santiago Cruz Perez";
            if (id == 2)
                customerName = "David Cruz Zavaleta";
            if (id == 3)
                customerName = "Cecilia Perez Morales";

            return Content(customerName);
        }
    }
}