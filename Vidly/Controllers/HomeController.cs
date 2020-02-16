using System.Web.Mvc;
using Vidly.Models;

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
    }
}