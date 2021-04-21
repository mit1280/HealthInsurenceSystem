using HealthInsurenceSystem.Data;
using HealthInsurenceSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsurenceSystem.Controllers
{
    public class AgentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AgentController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Purchased()
        {
            return View();
        }
        public IActionResult Sold()
        {
            string agent = HttpContext.Session.GetString("emailID");
            IEnumerable<Customer>  c =_db.Customer.Where(a=>a.Aemail==agent);
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Customer obj)
        {
            Policy p = _db.Policy.Find(obj.Ptype);
            obj.Duration = (int)p.Duration;
            obj.Amount = (int)p.MonthPremium;
            obj.Aemail= HttpContext.Session.GetString("emailID");
            DateTime now = DateTime.Today;
            obj.Purchaseddate = now;
            _db.Customer.Add(obj);
            _db.SaveChanges();
            return View("Purchased", obj);
        }
    }
}
