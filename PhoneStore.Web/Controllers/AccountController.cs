using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using PhoneStore.Web.Models;
using PhoneStore.Model.Customers;
using PhoneStore.Data;
using System.Web.Security;

namespace PhoneStore.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private PhoneStoreDBContext db = new PhoneStoreDBContext(); 
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel userVM)
        {
            if (ModelState.IsValid)
            {
                //var user = await UserManager.FindAsync(model.UserName, model.Password);
                //if (user != null)
                //{
                //    await SignInAsync(user, model.RememberMe);
                //    return RedirectToLocal(returnUrl);
                //}

                if (db.Users.Where(u => u.UserName == userVM.UserName).Single() != null)
                {  
                    FormsAuthentication.SetAuthCookie(userVM.UserName, userVM.RememberMe);
                    return RedirectToAction("Index", "Phone");
                } 
                else
                { 
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }
            
            // If we got this far, something failed, redisplay form
            return View(userVM); 
        }

        //
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                //var user = new ApplicationUser() { UserName = model.UserName };
                //var result = await UserManager.CreateAsync(user, model.Password);
                //if (result.Succeeded)
                //{
                //    await SignInAsync(user, isPersistent: false);
                //    return RedirectToAction("Index", "Home");
                //}
                //else
                //{
                //    AddErrors(result);
                //}

                var user = new User();
                        
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

    }
}