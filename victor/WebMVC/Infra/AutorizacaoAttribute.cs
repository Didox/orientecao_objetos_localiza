using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using WebMVC.Models;
using WebMVC.Services;

namespace Infra
{
    public class AutorizacaoAttribute : ActionFilterAttribute
    {
        public TipoDeAcesso perfil { get; set; }

        public override void OnActionExecuting(
            ActionExecutingContext filterContext
        )
        {
            string tipoDeAcesso =
                filterContext.HttpContext.Request.Cookies["Login"];

            if (tipoDeAcesso != null)
            {
                var usuario =
                    JsonConvert.DeserializeObject<UserLogin>(tipoDeAcesso);
                if (perfil == TipoDeAcesso.ADMIN)
                {
                    if (usuario.Acesso == TipoDeAcesso.ADMIN)
                    {
                        return;
                    }
                }
                else if (perfil == TipoDeAcesso.USUARIO)
                {
                    if (usuario.Acesso == TipoDeAcesso.USUARIO)
                    {
                        return;
                    }
                }
            }

            filterContext.HttpContext.Response.Redirect("/Home/Autorizacao");
            return;
            base.OnActionExecuting(filterContext);
        }
    }
}
