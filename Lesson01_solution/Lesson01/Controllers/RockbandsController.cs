using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lesson01_solution.Controllers
{
    public class RockbandsController : Controller
    {
        public IActionResult Index()
        {
            string[] rockbands = { "Led Zeppelin", "The Beatles", "Pink Floyd", "The Jimi Hendrix Experience", "The Rolling Stones", "Queen", "Santana", "Metallica", "U2", "The Who" };

            ViewBag.Rockbands = rockbands;


            return View();
        }
    }
}