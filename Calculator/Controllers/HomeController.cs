using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Result()
        {
            double nbr1 = Convert.ToDouble(Request.QueryString.Get("nbr1"));
            double nbr2 = Convert.ToDouble(Request.QueryString.Get("nbr2"));

            string op = Request.QueryString.Get("op");

            switch (op)
            {
                case "+":
                    ViewBag.res = nbr1 + nbr2;
                    break;

                case "-":
                    ViewBag.res = nbr1 - nbr2;
                    break;

                case "*":
                    ViewBag.res = nbr1 * nbr2;
                    break;

                case "/":
                    ViewBag.res = nbr1 / nbr2;
                    break;

                default:
                    ViewBag.res = "Invalid operator";
                    break;
            }

            return View("Index");
        }
    }
}