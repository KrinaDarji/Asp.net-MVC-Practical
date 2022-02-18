using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_14_windows.Controllers
{
    public class HomeController : Controller
    {
       [Authorize(Users = @"SF-CPU-310\krina")]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Users = @"SF-CPU-310\SimformSolutions")]
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