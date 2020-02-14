using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        private MyDbContext _context;

        public HomeController()
        {
            _context = new MyDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        { 
            return View();
        }

        public ActionResult Customers()
        {
            //var customers = _context.Customers;

            var customers = new List<Customer>
            {
                new Customer {Name = "Paweł Pabiańczyk", Id = 1},
                new Customer {Name = "Julia Migdał", Id = 2}
            };

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Movies()
        {
            var movies = new List<Movie>
            {
                new Movie {Name = "Przygody Fabiana"},
                new Movie {Name = "Przygody Fabiana 2"}
            };

            var viewModel = new MoviesViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }

        public ActionResult ByCustomersDetails(int id)
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "Paweł Pabiańczyk", Id = 1},
                new Customer {Name = "Julia Migdał", Id = 2}
            };

            if (id > customers.Count || id<1)
                return HttpNotFound();
            else
                return Content(customers[id-1].Name);
        }
    }
}