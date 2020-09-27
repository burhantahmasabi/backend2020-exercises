using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lesson05.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string countries)
        {
            return View();
        }
    }
}