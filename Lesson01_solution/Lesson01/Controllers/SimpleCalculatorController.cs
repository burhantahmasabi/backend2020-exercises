using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson01.Controllers
{
    public class SimpleCalculatorController : Controller
    {
        public IActionResult Index(IFormCollection fc)
        {
            if (fc["number1"] != "" && fc["number2"] != "")
            {
                decimal number1 = Convert.ToDecimal(fc["number1"]);
                decimal number2 = Convert.ToDecimal(fc["number2"]);
                string thisOperator = fc["operator"].ToString();

                switch (thisOperator)
                {
                    case "+":
                        ViewBag.Result = number1 + number2;
                        break;
                    case "-":
                        ViewBag.Result = number1 - number2;
                        break;
                    case "*":
                        ViewBag.Result = number1 * number2;
                        break;
                    case "/":
                        if (number2 != 0)
                        {
                            ViewBag.Result = number1 / number2;
                        }
                        else
                        {
                            ViewBag.Result = "Division by 0 error";
                        }
                        break;
                    default:
                        break;
                }
                ViewBag.Number1 = number1;
                ViewBag.Number2 = number2;
            }
            return View();
        }
    }
}