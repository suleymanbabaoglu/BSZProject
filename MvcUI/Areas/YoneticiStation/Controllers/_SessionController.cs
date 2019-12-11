﻿using System.Web;
using System.Web.Mvc;

namespace MvcUI.Areas.YoneticiStation.Controllers
{
    class _SessionControlAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                if (!HttpContext.Current.Response.IsRequestBeingRedirected)
                    filterContext.HttpContext.Response.Redirect("/YoneticiStation/Login/Login");
            }
        }
    }
}