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
    public class PaymentController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PaymentController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PaymentPage()
        {
            return View();
        }
        public IActionResult PaymentDone()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Customer obj)
        {
            Customer x1 = _db.Customer.Find(obj.Pnumber);
            if (ModelState.IsValid)
            {
                if (x1 == null)
                {
                    HttpContext.Session.SetInt32("emailError", 1);
                    return RedirectToAction("Index");
                }
                DateTime dat;
                DateTime now = DateTime.Today;
                if (x1.Lastpayment==null)
                {
                    dat = (DateTime)x1.Purchaseddate;
                }
                else
                {
                     dat = (DateTime)x1.Lastpayment;
                }
                   if(x1.Lastpayment == null)
                {
                   
                    TempData["Ldate"] = dat;
                    TempData["Amount"] = Int32.Parse(x1.Amount.ToString());
                    TempData["Policy number"] = x1.Pnumber;
                    TempData["Epay"] = x1.Cemail;
                    TempData["data"] = x1.Amount;
                    HttpContext.Session.SetInt32("CardNumber", 0);
                    return RedirectToAction("PaymentPage");
                }
                
                    if (now.Month - dat.Month > 0)
                    {
                        TempData["Policy number"] = x1.Pnumber;
                        TempData["Policy type"] =x1.Ptype;
                        TempData["Epay"] = x1.Cemail;
                        TempData["Amount"]= Int32.Parse(TempData["Amount"].ToString())* (now.Month - dat.Month);
                        TempData["data"]=Int32.Parse(TempData["data"].ToString())* (now.Month - dat.Month);
                    HttpContext.Session.SetInt32("CardNumber", 0);
                    return RedirectToAction("PaymentPage");
                    }
                    else
                    {
                        return RedirectToAction("PaymentDone");
                    } 
            }
            return RedirectToAction("Notok");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult check(Payment obj)
        {
            DateTime now = DateTime.Today;
            IEnumerable<Payment> x1 = _db.Payment.Where(a => a.Cardnumber == obj.Cardnumber && a.ExpiredDate==obj.ExpiredDate && a.Cvv == obj.Cvv);
            if (ModelState.IsValid)
            {
                
                if (x1.Count() > 0)
                {
                    Paymentlog p = new Paymentlog();
                    DateTime dat = (DateTime)TempData["Ldate"];
                    string x= TempData["Policy number"].ToString();
                    p.Cemail = TempData["Epay"].ToString();
                    p.Paymentdate = now;
                    p.Pnumber = Int32.Parse(x);
                    _db.Paymentlog.Add(p);
                    _db.SaveChanges();
                    Customer lpay = _db.Customer.Find(Int32.Parse(x));
                    lpay.Lastpayment = now;
                    _db.SaveChanges();
                    lpay.Duration=lpay.Duration- dat.Month;
                    _db.SaveChanges();
                    return View(_db.Paymentlog.Where(a=> a.Pnumber== Int32.Parse(x)));
                }
                else
                {
                    HttpContext.Session.SetInt32("CardNumber", 1);
                    return RedirectToAction("PaymentPage");
                }
            }
            return View("Notok");
        }
    }
}
