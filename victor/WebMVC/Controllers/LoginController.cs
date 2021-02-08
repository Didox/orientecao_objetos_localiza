using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Infra;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebMVC.Models;
using WebMVC.Services;
using Newtonsoft.Json;

namespace Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [Route("/Login")]
        public void EfetuarLogin(UserLogin userLogin)
        {
            // Chamar serviço que efetua verificação do Login do usuário
            string username = userLogin.Username;
            string password = userLogin.Password;

            var usuarioJSON = JsonConvert.SerializeObject(LoginService.ValidaLogin(username, password));            

            if (usuarioJSON != null)
            {
                this
                    .HttpContext
                    .Response
                    .Cookies
                    .Append("Login",
                    usuarioJSON,
                    new CookieOptions {
                        Expires = DateTimeOffset.UtcNow.AddSeconds(15),
                        HttpOnly = true
                    });
                this.HttpContext.Response.Redirect("/");
            }
            else
            {
                this.HttpContext.Response.Redirect("/Home/Login");
            }
        }
    }
}

// Gravar obj serializado
