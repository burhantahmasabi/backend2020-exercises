using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public IActionResult Index()
        {
            
            Customer c1 = new Customer("Ken", "Thompson", "Byagervej 17", "9000", "Aalborg");
            c1.AddPhone("1218 2419");
            c1.AddPhone("2234 4518");
            c1.Birthdate = new DateTime(1987, 4, 6);
            ViewBag.C1 = c1;

            Customer c2 = new Customer("Kirstein", "Roth", "Vibevej 22", "8300", "Odder");
            c2.AddPhone("2214 2818");
            c2.AddPhone("1230 4956");
            c2.Birthdate = new DateTime(1992, 07, 12);
            ViewBag.C2 = c2;
            return View();
        }
    }
}