using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzz.Controllers
{
    //Inherits from Controller class
    public class HomeController : Controller 
    {
        public ActionResult Index()  //ActionResult is the Return Type Index is the action
        {
            return View();
        }
        //sets the layouts - returns the results of view method
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