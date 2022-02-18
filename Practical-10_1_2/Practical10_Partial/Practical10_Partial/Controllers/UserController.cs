using Practical10_Partial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical10_Partial.Controllers
{
    public class UserController : Controller
    {
        /// <summary>
        /// display user
        /// </summary>
        /// <returns>view</returns>
        public ActionResult Index()
        {
            ViewBag.model = User;
            return View(Repository.AllUser);
        }
        /// <summary>
        /// create user
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {

            return View();
        }
        /// <summary>
        /// add user 
        /// </summary>
        /// <param name="user"></param>
        /// <returns>redirected to user page</returns>
        [HttpPost]
        public ActionResult Create(User user)
        {
            Repository res = new Repository();
            res.add(user);

            return RedirectToAction("Index");

        }
        /// <summary>
        /// details of user
        /// </summary>
        /// <param name="id"></param>
        /// <returns>id</returns>
        public ActionResult Details(int id)
        {
            Repository res = new Repository();
            var r = res.Get(id);
            return View(r);
        }
        /// <summary>
        /// get user id for delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns>id</returns>
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Repository res = new Repository();
            var r = res.Get(id);
            return View(r);
        }
        /// <summary>
        /// delete user from given id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="form"></param>
        /// <returns>redirected to index page</returns>
        [HttpPost]
        public ActionResult Delete(int id, FormCollection form)
        {
            Repository res = new Repository();
            res.Delete(id);
            return RedirectToAction("Index");
        }
        /// <summary>
        /// edit user from id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>id</returns>
        public ActionResult Edit(int id)
        {
            Repository res = new Repository();
            var m = res.Get(id);
            if (m == null)
            {
                return HttpNotFound();
            }
            return View(m);
        }
        /// <summary>
        /// edit changes 
        /// </summary>
        /// <param name="user"></param>
        /// <returns>view</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User user)
        {
            Repository res = new Repository();
            if (ModelState.IsValid)
            {
                res.Edit(user);
                return RedirectToAction("Details", new { ID = user.ID });
            }
            return View(user);
        }

    }
}