using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using MvcUI.Models;
using MvcUI.Models.Entities;

namespace MvcUI.Areas.YoneticiStation.Controllers
{
    public class LoginController : Controller
    {


        [AllowAnonymous]
        public ActionResult Login()
        {
            Users _user = new Users();
            if (String.IsNullOrEmpty(HttpContext.User.Identity.Name))
            {
                FormsAuthentication.SignOut();
                return View(_user);
            }
            return Redirect("~/YoneticiStation/AdminHome/");
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(Users user, string returnurl)
        {
            using (var db = new BSZContext())
            {
                var u = db.users.FirstOrDefault();
                if (u.Email == user.Email && u.Password == user.Password)
                {
                    FormsAuthentication.SetAuthCookie(user.Email, true);
                    return Redirect("~/YoneticiStation/AdminHome/");
                }

                else
                {
                    return View(user);
                }
            }

            
        }
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}