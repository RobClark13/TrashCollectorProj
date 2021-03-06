﻿using Microsoft.AspNetCore.Http;
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
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee= _context.Employees.Where(c => c.IdentityUserID == userId).SingleOrDefault();
           
            if (employee== null)
            {
                return RedirectToAction("Create");
            }
            string today = System.DateTime.Now.DayOfWeek.ToString();
           
            var customers = _context.Customers.Where(c => c.ZipCode == employee.ZipCode && c.PickupDay == today);
            return View(customers);
        }
        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            employee.IdentityUserID = userid;
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET: HomeController1/Create
        public ActionResult Confirm(int id)
        {
            var confirmCustomer = _context.Customers.Find(id);
            return View(confirmCustomer);
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Confirm(Customer customer)
        {
            var customerConfirmed = _context.Customers.SingleOrDefault(mbox => mbox.Id == customer.Id);
            customerConfirmed.BalanceDue += 10;
            customerConfirmed.PickupConfirm = true;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: HomeController1/Create
        public ActionResult ListOfCustByDay(string sortOrder, string searchString)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employees.Where(c => c.IdentityUserID == userId).SingleOrDefault();
            var customers = _context.Customers.Where(c => c.ZipCode == employee.ZipCode);
            if (!String.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(c => c.PickupDay.Contains(searchString));
            }
            return View(customers);
        }
        //public ActionResult SeeMap(int id)
        //{

        //}

       




    }
}
