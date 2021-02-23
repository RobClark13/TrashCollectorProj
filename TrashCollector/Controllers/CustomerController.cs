using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(c => c.IdentityUserID == userId).SingleOrDefault();
            return View(customer);
        }
        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            customer.IdentityUserID = userid;
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

       //Get:
       public ActionResult SuspendService(int id)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(c => c.IdentityUserID == userId).SingleOrDefault();
            return View(customer);
        }
        //Post 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SuspendService(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //Get:
        public ActionResult ChangePickupDay(int id)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(c => c.IdentityUserID == userId).SingleOrDefault();
            return View(customer);
        }
        //Post 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePickupDay(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ViewBalance()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(c => c.IdentityUserID == userId).SingleOrDefault();
            return View(customer);
        }
        //Get:
        public ActionResult AddPickupDay(int id)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(c => c.IdentityUserID == userId).SingleOrDefault();
            return View(customer);
        }
        //Post 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPickupDay(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
