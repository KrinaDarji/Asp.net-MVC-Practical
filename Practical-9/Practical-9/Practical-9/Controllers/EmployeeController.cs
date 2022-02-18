using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_9.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        // string value passed from the URL should be displayed on the web page
        public ActionResult Search(string name)
        {
            var input = Server.HtmlEncode(name);
            return Content(input);
        }
        
    }
}