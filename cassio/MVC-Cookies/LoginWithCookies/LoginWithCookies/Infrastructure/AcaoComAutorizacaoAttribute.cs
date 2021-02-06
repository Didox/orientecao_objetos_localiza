using LoginWithCookies.Enums;
using LoginWithCookies.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace LoginWithCookies.Controllers
{
    internal class AcaoComAutorizacaoAttribute : ActionFilterAttribute
    {

        public string RoleForAuthorization { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (string.IsNullOrEmpty(filterContext.HttpContext.Request.Cookies["Usuario"]))
            {
                filterContext.HttpContext.Response.Redirect("/Home/Login");
                return;
            }
            else
            {
                foreach (var cookie in filterContext.HttpContext.Request.Cookies)
                {
                    if (cookie.Key == "Usuario")
                    {
                        var usuario = JsonConvert.DeserializeObject<Usuario>(cookie.Value);

                        if (usuario.Role == Roles.administrador && RoleForAuthorization == "Administrador")
                        {
                            usuario.Authorized = true;
                            return;
                        }

                        if (usuario.Role == Roles.editor && RoleForAuthorization == "Editor")
                        {
                            usuario.Authorized = true;
                            return;
                        }

                        if (usuario.Role == Roles.estagiario && RoleForAuthorization == "Estagiario")
                        {
                            usuario.Authorized = true;
                            return;
                        }
                    }
                }

                filterContext.HttpContext.Response.Redirect("/Home/Login");
                return;
            }

            base.OnActionExecuting(filterContext);
        }
    }
}