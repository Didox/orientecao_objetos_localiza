using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Infra;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebMVC.Models;

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
        public void EfetuarLogin()
        {
            // Chamar serviço que efetua verificação do Login do usuário
            this
                .HttpContext
                .Response
                .Cookies
                .Append("Localiza",
                "UserLogin",
                new CookieOptions {
                    Expires = DateTimeOffset.UtcNow.AddSeconds(5),
                    HttpOnly = true
                });
            this.HttpContext.Response.Redirect("/");
        }
    }
}
