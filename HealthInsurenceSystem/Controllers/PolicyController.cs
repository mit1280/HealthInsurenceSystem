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
    public class PolicyController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PolicyController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            String email = HttpContext.Session.GetString("emailID"); 
            IEnumerable<Customer> x1 = _db.Customer.Where(a => a.Cemail == email);
            
            return View(x1);
        }
    }
}
