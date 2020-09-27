using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson05.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson05.Controllers
{
    public class Exercise03Controller : Controller
    {
        public IActionResult Index()
        {
            BreakfastOrder breakfastOrder = new BreakfastOrder();

            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 1, Name = "Cornflakes", Price = 36, Selected=false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 2, Name = "Egg", Price = 36, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 3, Name = "Toast", Price = 18, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 4, Name = "Juice", Price = 40, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 5, Name = "Milk", Price = 24, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 6, Name = "Coffee", Price = 42, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 7, Name = "Tea", Price = 32, Selected = false });


            return View(breakfastOrder);
        }

        [HttpPost]
        public IActionResult Index(BreakfastOrder breakfastOrder)
        {
            return View("Receipt", breakfastOrder);
        }
    }
}