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
      if( string.IsNullOrEmpty(filterContext.HttpContext.Request.Cookies["Alunos"]) ){
        filterContext.HttpContext.Response.Redirect("/Home/Privacy");
        return;
      }

      base.OnActionExecuting(filterContext);
    }
}
}