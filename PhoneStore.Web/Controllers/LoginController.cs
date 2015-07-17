using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace PhoneStore.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
            private void SignIn(List<Claim> claims)//Mind!!! This is System.Security.Claims not WIF claims
            {
                claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, "Brock"));
                claims.Add(new Claim(ClaimTypes.Email, "brockallen@gmail.com"));
                var id = new ClaimsIdentity(claims,
                                            DefaultAuthenticationTypes.ApplicationCookie);

                var ctx = Request.GetOwinContext();
                var authenticationManager = ctx.Authentication;
                authenticationManager.SignIn(id);
       }

            //var ctx = Request.GetOwinContext();
            //var authenticationManager = ctx.Authentication;
            //authenticationManager.SignOut();

    }
}