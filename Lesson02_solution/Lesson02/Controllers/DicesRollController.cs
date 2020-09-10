using Lesson02.Models;
using Lesson02.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson02.Controllers
{
    public class DicesRollController : Controller
    {
        public IActionResult Index()
        {
            
            HttpContext.Session.SetJson("dice", null);
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection fc)
        {
            Dice dice1;
            if (HttpContext.Session.GetJson<Dice>("dice1") == null)
            {
                dice1 = new Dice();
                dice1.Roll();
                HttpContext.Session.SetJson("dice1", dice1);
            }
            else
            {
                dice1 = HttpContext.Session.GetJson<Dice>("dice1");
                dice1.Roll();
                HttpContext.Session.SetJson("dice1", dice1);
            }
            ViewBag.Dice1 = dice1;

            Dice dice2;
            if (HttpContext.Session.GetJson<Dice>("dice2") == null)
            {
                dice2 = new Dice();
                dice2.Roll();
                HttpContext.Session.SetJson("dice2", dice2);
            }
            else
            {
                dice2 = HttpContext.Session.GetJson<Dice>("dice2");
                dice2.Roll();
                HttpContext.Session.SetJson("dice2", dice2);
            }
            ViewBag.dice2 = dice2;

            return View();
        }
    }
}