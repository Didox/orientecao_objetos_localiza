using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace Infra
{
  public class VerificaUsuarioLogado : ActionFilterAttribute
  {
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
      // if( string.IsNullOrEmpty(filterContext.HttpContext.Session.GetString("Alunos")) ){
      //   filterContext.HttpContext.Response.Redirect("/Home/Privacy");
      //   return;
      // }
      
      if( string.IsNullOrEmpty(filterContext.HttpContext.Request.Cookies["Localiza"]) ){
        filterContext.HttpContext.Response.Redirect("/Home/Login");
        return;
      }

      base.OnActionExecuting(filterContext);
    }
  }
}