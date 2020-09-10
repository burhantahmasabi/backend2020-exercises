using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lesson01_solution.Controllers
{
    public class DisplayNameController : Controller
    {
        public IActionResult Index()
        {

            string name;
            int age;
            DateTime birthday;

            name = "Karen Jansen";
            age = 32;
            birthday = new DateTime(1986, 5, 12);

            ViewBag.Name = name;
            ViewBag.Age = age;
            ViewBag.Birthday = birthday;

            return View();
        }
    }
}