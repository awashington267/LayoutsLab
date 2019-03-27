using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutsLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Stuff(int? id, string name)
        {
            ViewBag.number = id;
            ViewBag.name = name;
            return View();
        }
        [HttpPost]
        public ActionResult AddNumbers(FormCollection Form)
        {
            double num1, num2;
            if(Double.TryParse(Form["num1"], out num1) && Double.TryParse(Form["num2"], out num2))
            {
                ViewBag.Total = num1 + num2;
            }
            else
            {
                ViewBag.Total = "Invalid";
            }
            return View();
        }

        public ActionResult DisplayList()
        {
            //create an array of strings
            string[] names = { "Jeff", "Bob", "Mary" };
            //"put" the array  in the viewbag
            ViewBag.names = names;
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}