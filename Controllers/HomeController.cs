using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(double firstNumber, double secondNumber, string operation)
        {
            double total = 0.0;

            switch (operation)
            {
                case "+":
                    total = firstNumber + secondNumber;
                    ViewBag.total = total;
                    break;
                case "-":
                    total = firstNumber - secondNumber;
                    ViewBag.total = total;
                    break;
                case "*":
                    total = firstNumber * secondNumber;
                    ViewBag.total = total;
                    break;
                case "/":
                    total = firstNumber / secondNumber;
                    ViewBag.total = total;
                    break;
                default:
                    total = 0;
                    break;
            }

            return View();
        }
    }
}