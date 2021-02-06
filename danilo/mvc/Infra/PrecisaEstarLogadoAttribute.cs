using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace mvc.Infra
{
  public class PrecisaEstarLogadoAttribute : ActionFilterAttribute
  {
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
      // if( string.IsNullOrEmpty(filterContext.HttpContext.Session.GetString("Alunos")) ){
      //   filterContext.HttpContext.Response.Redirect("/Home/Privacy");
      //   return;
      // }
      
      if( string.IsNullOrEmpty(filterContext.HttpContext.Request.Cookies["Alunos"]) ){
        filterContext.HttpContext.Response.Redirect("/Home/Privacy");
        return;
      }

      base.OnActionExecuting(filterContext);
    }
  }
}