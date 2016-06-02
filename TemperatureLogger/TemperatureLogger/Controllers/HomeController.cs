using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemperatureLogger.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Temperature()
        {
            return View();
            
        }

        public ActionResult Humidity()
        {
            return View();
        }
    
      }
}