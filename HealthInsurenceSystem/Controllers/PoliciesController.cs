using HealthInsurenceSystem.Data;
using HealthInsurenceSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace HealthInsurenceSystem.Controllers
{
    public class PoliciesController : Controller
    {

        private readonly ApplicationDbContext _db;

        public PoliciesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            IEnumerable<Policy> objList = _db.Policy;
            return View(objList);
        }
        public IActionResult Interest()
        {

            return View();
        }
        public IActionResult knowmore()
        {
            return View();
        }
        public IActionResult addtocart(string Ptype)
        {
            
            var obj = _db.Policy.Find(Ptype);
            return View(obj);
        }
        public IActionResult deletefromcart(string Ptype)
        {
            var obj = _db.Policy.Find(Ptype);
            return View(obj);
        }
        public IActionResult SuperPlatinum()
        {
            return View();
        }
        public IActionResult Standard()
        {
            return View();
        }
        public IActionResult Gold()
        {
            return View();
        }
        public IActionResult Platinum()
        {
            return View();
        
        }
        public IActionResult Silver()
        {
            return View();
        }

        public IActionResult payonline()
        {
        
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult addtocart(Interested obj)
        {

            if (ModelState.IsValid)
            {
                _db.Interested.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Interest");
            }
            return View(obj);
        }
    }
}
