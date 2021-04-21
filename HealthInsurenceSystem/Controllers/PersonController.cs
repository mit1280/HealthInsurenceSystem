using HealthInsurenceSystem.Data;
using HealthInsurenceSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace HealthInsurenceSystem.Controllers
{
    public class PersonController : Controller
    {

        private readonly ApplicationDbContext _db;

        public PersonController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult ok()
        {
            return View();
        }
        public IActionResult Notok()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult login(Person obj)
        {
            IEnumerable<Person> x1 = _db.Person.Where(a=>a.Email==obj.Email && a.Password==obj.Password);
            
            if (ModelState.IsValid) 
            {
                if (x1.Count()>0)
                {
                    int x = x1.First().Email.IndexOf("his");
                    int y = x1.First().Email.IndexOf("admin");
                    if (x-y==6)
                    {
                        HttpContext.Session.SetInt32("loggedIn", 3);
                        HttpContext.Session.SetString("emailID", x1.First().Email);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        if (x1.First().Email.IndexOf("his") > 0)
                        {
                            HttpContext.Session.SetInt32("loggedIn", 2);
                            HttpContext.Session.SetString("emailID", x1.First().Email);
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            HttpContext.Session.SetInt32("loggedIn", 1);
                            HttpContext.Session.SetString("emailID", x1.First().Email);
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }
                else
                {
                    return RedirectToAction("Notok");
                }
            }
            return RedirectToAction("Notok");
        }
        public IActionResult signup()
        {
            return View();
        }
        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult signup(Person obj)
        {
            if (ModelState.IsValid)
            {
                _db.Person.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("login");
            }
            return View(obj);
        }
    }
}


