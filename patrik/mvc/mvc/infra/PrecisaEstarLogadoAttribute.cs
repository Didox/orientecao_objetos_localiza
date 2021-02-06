using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace mvc.Infra
{
    public class PrecisaEstarLogadoAttribute : ActionFilterAttribute
    {
        private bool checkLogin(ActionExecutingContext filterContext)
        {
            var cookie = filterContext.HttpContext.Request.Cookies["Logado"];
            if (cookie == null)
            {
                return false;
            }
            return true;
        }
        
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!this.checkLogin(filterContext))
            {
                filterContext.HttpContext.Response.Redirect("/Home/Login");
                return;
            }

            base.OnActionExecuting(filterContext);
        }
    }
}