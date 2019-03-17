using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_MVC.Models;

namespace Vidly_MVC.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer(){ Id = 1, Name = "John Jones" },
            new Customer(){ Id = 2, Name = "Anna Priva"},
            new Customer(){ Id = 3, Name = "Paul Bennet"}
        };    
        // GET: Customers
        public ActionResult Index()
        {
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = customers.FirstOrDefault(c => c.Id == id);
            return View(customer);
        }
    }
}