using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using System.Web.Security;
using PhoneStore.Data;
using PhoneStore.CMS.Models;
using PhoneStore.CMS.Extensions;
using PhoneStore.Model.Customers;


namespace PhoneStore.CMS.Controllers
{
    public class AccountController : Controller
    {

        private PhoneStoreDBContext db = new PhoneStoreDBContext();
       
    //GET 
    public ActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Phone");
            }
            return View();
        }

    [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel userVM)
        {
            if (ModelState.IsValid)
            {

                //var user = userVM.ToEntity();        
                //if (userVM.UserName.Equals("admin") && userVM.Password.Equals("admin")) 
                if (db.Users.Any(u => u.UserName.Equals(userVM.UserName) && u.Password.Equals(userVM.Password)))  
                {
                    FormsAuthentication.SetAuthCookie(userVM.UserName, userVM.RememberMe);
                    return RedirectToAction("Index", "Phone");
                } 
                else
                { 
                    ModelState.AddModelError("", "Login data is incorrect!"); 
                }
            } 
            
            return View(userVM); 
        }
            
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        } 
} 

