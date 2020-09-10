using Lesson02.Models;
using Lesson02.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lesson02.Controllers
{
    public class DiceRollController : Controller
    {


        public IActionResult Index()
        {
            List<Dice> diceList = new List<Dice>();
            diceList.Add(new Dice());

            
            HttpContext.Session.SetJson("dice", null);
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection fc)
        {
            Dice dice;
            if (HttpContext.Session.GetJson<Dice>("dice") == null)
            {
                dice = new Dice();
                dice.Roll();
                HttpContext.Session.SetJson("dice", dice);
            }
            else
            {
                dice = HttpContext.Session.GetJson<Dice>("dice");
                dice.Roll();
                HttpContext.Session.SetJson("dice", dice);
            }
            ViewBag.Dice = dice;

            return View();
        }
    }
}