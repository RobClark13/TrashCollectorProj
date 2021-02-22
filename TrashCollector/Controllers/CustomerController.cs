using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
            
            return View();
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
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

       //Get:
       public ActionResult SuspendService(int id)
        {
            var customerService = _context.Customers.Find(id);
            return View(customerService);
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
            var customerService = _context.Customers.Find(id);
            return View(customerService);
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
    }
}
