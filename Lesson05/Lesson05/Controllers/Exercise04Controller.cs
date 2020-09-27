using Lesson05.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Lesson05.Controllers
{
    public class Exercise04Controller : Controller
    {
        private ParkingTicketMachine ptm = new ParkingTicketMachine();

        public IActionResult Index()
        {
            ViewBag.Payback = false;
            return View(ptm);
        }

        [HttpPost]
        public ActionResult Index(IFormCollection fc)
        {
            // create a new instance of ParkingTicketMachine
            ParkingTicketMachine ptm = new ParkingTicketMachine();

            // declare a variable which keeps track of the amount inserted
            int AmountInserted;
            ViewBag.Payback = false;
            ViewBag.PaybackAmount = 0;

            // the hidden field AmountInserted holds the inserted amount 
            if (!String.IsNullOrEmpty(fc["AmountInserted"]))
            {
                AmountInserted = Convert.ToInt16(fc["AmountInserted"]); // read the value of the amount inserted
            }
            else
            {
                AmountInserted = 0; // otherwise set the value to 0
            }

            if (!String.IsNullOrEmpty(fc["1"]))
            {
                // call the InsertCoin method with 1+AmountInserted as as parameter
                ptm.InsertCoin(1 + AmountInserted);
            }
            else if (!String.IsNullOrEmpty(fc["2"]))
            {
                ptm.InsertCoin(2 + AmountInserted);
            }
            else if (!String.IsNullOrEmpty(fc["5"]))
            {
                ptm.InsertCoin(5 + AmountInserted);
            }
            else if (!String.IsNullOrEmpty(fc["10"]))
            {
                ptm.InsertCoin(10 + AmountInserted);
            }
            else if (!String.IsNullOrEmpty(fc["20"]))
            {
                ptm.InsertCoin(20 + AmountInserted);
            }

            
            if (!String.IsNullOrEmpty(fc["cancel"]))
            {
                // reset the model to its initial state
                ViewBag.Payback = true;
                ViewBag.PaybackAmount = AmountInserted;
                ptm = new ParkingTicketMachine();
            }

            if (!String.IsNullOrEmpty(fc["confirm"]))
            {
                ptm.InsertCoin(AmountInserted);
                // load the receip  t view named "confirm" with the model as parameter
                return View("confirm", ptm);
            }

            // load the default view with the model as parameter
            return View(ptm);
        }
    }
}