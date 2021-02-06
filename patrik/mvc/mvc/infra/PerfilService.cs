using System;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Filters;

namespace mvc.Infra
{
    public class PerfilService
    {
        public static bool checkPerfil(ActionExecutingContext filterContext, string perfil)
        {
            var cookie = filterContext.HttpContext.Request.Cookies["Auth"];
            if (String.IsNullOrEmpty(cookie))
            {
                return false;
            }

            var user = JsonSerializer.Deserialize<User>(cookie);

            var perfis = perfil.Split(",");
            if (Array.IndexOf(perfis, user.Perfil) < 0)
            {
                return false;
            }
            return true;
        }
    }
}