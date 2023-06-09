using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_9.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string message = "Hello World";
            return View((object)message);
        }

        public ActionResult test2()
        {
            return View();
        }

        public ActionResult test3()
        {
            return View();
        }
    }
}