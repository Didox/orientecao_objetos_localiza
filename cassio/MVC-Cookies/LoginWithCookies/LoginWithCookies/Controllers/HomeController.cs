using LoginWithCookies.Enums;
using LoginWithCookies.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Diagnostics;

namespace LoginWithCookies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario obj)
        {

            if (!String.IsNullOrEmpty(obj.Login) && !String.IsNullOrEmpty(obj.Senha))
            {
                obj.Role = Roles.administrador;
                var serializableObj = JsonConvert.SerializeObject(obj);
                this.HttpContext.Response.Cookies.Append("Usuario", serializableObj, new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddSeconds(3600),
                    HttpOnly = true,

                });

                return RedirectToAction(nameof(Administrador));
            }

            return View();
        }

        [HttpGet]
        [AcaoComAutorizacao(RoleForAuthorization = "Editor")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AcaoComAutorizacao(RoleForAuthorization = "Estagiario")]
        public IActionResult Estagiario()
        {
            return View();
        }

        [HttpGet]
        [AcaoComAutorizacao(RoleForAuthorization = "Administrador")]
        public IActionResult Administrador()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
