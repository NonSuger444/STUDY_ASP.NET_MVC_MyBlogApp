﻿using MyBlogApp.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace MyBlogApp.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        readonly private CustomMembershipProvider membershipProvider = new CustomMembershipProvider();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "UserName.Password")] LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (this.membershipProvider.ValidateUser(model.UserName, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "Articles");
                }
            }
            return View(model);
        }

        // GET: Login/SignOut
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Articles");
        }
    }
}