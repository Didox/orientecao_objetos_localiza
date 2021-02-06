using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace mvc_login.Infra
{
    public class PrecisaEstarLogado : ActionFilterAttribute
    {
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
      if( string.IsNullOrEmpty(filterContext.HttpContext.Request.Cookies["Login"]) ){
        filterContext.HttpContext.Response.Redirect("/Home/Login");
        return;
      }

      base.OnActionExecuting(filterContext);
    }
}
}