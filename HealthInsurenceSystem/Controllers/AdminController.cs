using HealthInsurenceSystem.Data;
using HealthInsurenceSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsurenceSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddAgent()
        {
            return View();
        }
        public IActionResult AddedAgent()
        {
            return View();
        }
        public IActionResult AddedPolicy()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddAgent(Person obj)
        {

            if (ModelState.IsValid)
            {
                _db.Person.Add(obj);
                _db.SaveChanges();
                Person p = _db.Person.Where(a => a.Email == obj.Email).First();
                TempData["cnm"] = p.Cnumber;
                TempData["dob"] = p.Dob;
                TempData["em"] = p.Email;
                TempData["nam"] = p.Name;
                TempData["pass"] = p.Password;
                return RedirectToAction("AddedAgent");
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Policy obj)
        {

            if (ModelState.IsValid)
            {
                _db.Policy.Add(obj);
                _db.SaveChanges();
                TempData["Ptype"]=obj.Ptype;
                TempData["pre"]=obj.MonthPremium;
                TempData["max"]=obj.MaxAge;
                TempData["min"] = obj.MinAge;
                TempData["dur"] = obj.Duration;
                return RedirectToAction("AddedPolicy");
            }
            return View(obj);
        }
    }
}
