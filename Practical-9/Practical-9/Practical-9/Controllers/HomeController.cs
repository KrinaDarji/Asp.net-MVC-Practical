using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_9.Controllers
{
    public class HomeController : Controller
    {
        //ContentResult as the return type of the Index action method and also we are returning HTML content.
        public ContentResult ContentResult()
        {
            return Content("<h3>Here's  is an example of Content Result where exception handled</h3>", "text/html", System.Text.Encoding.UTF8);
        }
        //Redirect Results is used for returning results to specific url. When you need to redirect to another action method, you can use RedirectResult Action Method.
        public RedirectResult redirectResult()
        {
            return Redirect("Index/Contact");
        }
        // It will return a blank page with no result.
        public EmptyResult Empty()
        {
            ViewBag.ItemList = "MVC Filter List Page";
            return new EmptyResult();
        }
        //returns the data back to the view or the browser in the form of JSON
        public JsonResult jsonResult()
        {
            Employee emp = new Employee()
            {
                ID = "01",
                Name = "Krina",
                Mobile = "9898989898"
            };
            return Json(emp, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// class for Employee details for jsonResult
        /// </summary>
        public class Employee
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Mobile { get; set; }
        }
        public FileResult FileResult()
        {
            return File("~/Files/files.txt", "text/plain");
        }
        //Represents a downloadable file (with the binary content).
        public FileContentResult DownloadContent()
        {
            var myfile = System.IO.File.ReadAllBytes(@"C:\Users\krina\Desktop\Hello.txt");
            return new FileContentResult(myfile, "application/txt");
        }
        public ActionResult jsResult()
        {
            return new JavaScriptResult("window.location.href = 'https://lms.simformsolutions.com/'");
        }



        public class JavaScriptResult : ContentResult
        {
            public JavaScriptResult(string script)
            {
                this.Content = script;
                this.ContentType = "application/javascript";
            }
        }
    
        public ActionResult Index()
        {
            
            return View();
            
        }
        //output caching of time for 5 mins
        [OutputCache(Duration= 300)]
        public ActionResult OutPutTest()
        {
           ViewBag.Date = DateTime.Now.ToString();
           
            return View();
        }
        //exception filter for divide by zero
        [MyExceptionFilter]
        public int Exception()
        {
            int a = 65;
            int b = 0;
            int c = a / b;

            return c;
        }
        public class MyExceptionFilter : FilterAttribute, IExceptionFilter

        {
            public void OnException(ExceptionContext filterContext)
            {
                if (!filterContext.ExceptionHandled)
                {
                    filterContext.Result = new ViewResult()
                    {
                        ViewName = "Error"
                    };

                }
                filterContext.ExceptionHandled = true;
            }
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