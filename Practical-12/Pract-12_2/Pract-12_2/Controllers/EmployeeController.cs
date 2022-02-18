using Model.App_Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pract_12_2.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeelinqDataContext db = new EmployeelinqDataContext();
        DesignationLinqDataContext db1 = new DesignationLinqDataContext();
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> employees = db.Employees.ToList();
            List<Designation> designations = db1.Designations.ToList();
            var emp = from d in employees
                      join des in designations on d.Designation_ID equals des.ID
                      select new ViewModel
                      {
                          employee = d,
                          designation = des
                      };
            var desdata = from des in db.Employees select des;

            return View(emp);
        }
        [HttpGet]
        public ActionResult Create()
        {
            var desdata = from des in db.Employees select des;
            ViewBag.deslist = new SelectList(db1.Designations, "ID", "DesignationName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            db.Employees.InsertOnSubmit(employee);
            db.SubmitChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Details(int id)
        {
            var model = db.Employees.Single(x => x.ID == id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Employees.Single(x => x.ID == id);
            if (model == null)
            {
                return View("NotFound");
            }
            var desdata = from des in db.Employees select des;
            ViewBag.deslist = new SelectList(db1.Designations, "ID", "DesignationName");
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {

            Employee des1 = db.Employees.Single(x => x.ID == employee.ID);
            des1.FirstName = employee.FirstName;
            des1.MiddleName = employee.MiddleName;
            des1.LastName = employee.LastName;
            des1.DOB = employee.DOB;
            des1.MobileNumber = employee.MobileNumber;
            des1.Salary = employee.Salary;
            des1.Address = employee.Address;
            des1.Designation_ID = employee.Designation_ID;
            
            db.SubmitChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {
            var model = db.Employees.Single(x => x.ID == id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection form)
        {
            var model = db.Employees.Single(x => x.ID == id);

            db.Employees.DeleteOnSubmit(model);
            db.SubmitChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Count()
        {
            List<Employee> emp = db.Employees.ToList();
            List<Designation> des = db1.Designations.ToList();



            var returnop = (from employee in emp
                            join e in db1.Designations on employee.Designation_ID equals e.ID
                            group e by e.DesignationName into data
                            select new countEmp
                            {
                                Designation_Name = data.Max(r => r.DesignationName),
                                count = data.Count(),
                            });
            string json = JsonConvert.SerializeObject(returnop);
            List<countEmp> countEmps = JsonConvert.DeserializeObject<List<countEmp>>(json);
            return View(countEmps);
        }
    }
}