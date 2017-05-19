using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            //return "This is my <b>default</b> action...";
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(String name, int numTimes = 1) {
            //return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View(); //(ViewBag)
        }
    }
}