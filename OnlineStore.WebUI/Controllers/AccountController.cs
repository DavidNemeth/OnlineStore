﻿using OnlineStore.Domain.Abstract;
using OnlineStore.Domain.Concrete;
using OnlineStore.Domain.Entities;
using OnlineStore.WebUI.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineStore.WebUI.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {        
        IAuthentication authentication;
        public AccountController(IAuthentication authentication)
        {
            this.authentication = authentication;
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                if (authentication.Authenticate(model.UserName, model.Password))
                {
                    System.Web.Security.FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return Redirect(ReturnUrl ?? Url.Action("Index", "Admin"));
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect login info");
                    return View();
                }
            }
            else
            {
                return View();
            }            
        }
        public ActionResult Logout()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            return RedirectToAction("List", "Product");
        }         
    }
}