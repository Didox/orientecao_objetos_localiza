using LoginWithCookies.Enums;
using LoginWithCookies.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace LoginWithCookies.Controllers
{
    internal class AcaoComAutorizacaoAttribute : ActionFilterAttribute
    {

        public string Role { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (string.IsNullOrEmpty(filterContext.HttpContext.Request.Cookies["Usuario"]))
            {
                filterContext.HttpContext.Response.Redirect("/Home/Login");
                return;
            }
            else
            {
                if (Role == "Administrador")
                {
                    foreach (var cookie in filterContext.HttpContext.Request.Cookies)
                    {
                        if (cookie.Key == "Usuario")
                        {
                            var usuario = JsonConvert.DeserializeObject<Usuario>(cookie.Value);

                            if (usuario.Role == Roles.administrador)
                            {
                                usuario.Authorized = true;
                                return;
                            }
                        }
                    }

                    filterContext.HttpContext.Response.Redirect("/Home/Login");
                    return;
                }

                if (Role == "Editor")
                {
                    foreach (var cookie in filterContext.HttpContext.Request.Cookies)
                    {
                        if (cookie.Key == "Usuario")
                        {
                            var usuario = JsonConvert.DeserializeObject<Usuario>(cookie.Value);

                            if (usuario.Role == Roles.editor)
                            {
                                usuario.Authorized = true;
                                return;
                            }
                        }
                    }

                    filterContext.HttpContext.Response.Redirect("/Home/Login");
                    return;

                }

                if (Role == "Estagiario")
                {
                    foreach (var cookie in filterContext.HttpContext.Request.Cookies)
                    {
                        if (cookie.Key == "Usuario")
                        {
                            var usuario = JsonConvert.DeserializeObject<Usuario>(cookie.Value);

                            if (usuario.Role == Roles.estagiario)
                            {
                                usuario.Authorized = true;
                                return;
                            }
                        }
                    }

                    filterContext.HttpContext.Response.Redirect("/Home/Login");
                    return;

                }

            }


            base.OnActionExecuting(filterContext);
        }
    }
}