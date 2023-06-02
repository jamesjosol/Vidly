using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    [AllowAnonymous]
    public class TestController : Controller
    {

        private ApplicationDbContext _context;

        public TestController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Customer_View(int customerid)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == customerid);

            return PartialView("CustomerView", customer);
        }
    }
}