using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc.Infra;
using mvc.Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [PrecisaEstarLogado]
        public IActionResult Index()
        {

            return View();
        }
        
        [PrecisaEstarLogado, Perfil(perfil = "Admin")]
        public IActionResult Admin()
        {
            return View();
        }
        
        [PrecisaEstarLogado, Perfil(perfil = "Admin,Editor")]
        public IActionResult Editor()
        {

            return View();
        }
        
        [PrecisaEstarLogado, Perfil(perfil = "Admin,Estagiario")]
        public IActionResult Estagiario()
        {

            return View();
        }

        public IActionResult Privacy(int time = 0)
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }

        private bool verificaUsuario(Login login)
        {
            var usuario = mvc.Infra.User.getUser(login.Email);

            if (usuario != null)
            {
                if (usuario.Email == login.Email && usuario.Password == login.Password)
                {
                    return true;
                }
            }

            return false;
        }
        
        public void Logar(Login login)
        {
            if ((!String.IsNullOrEmpty(login.Email) != null && !String.IsNullOrEmpty(login.Password) != null) && this.verificaUsuario(login))
            {
               var user = mvc.Infra.User.getUser(login.Email);
               this.HttpContext.Response.Cookies.Append("Logado", "true", new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddSeconds(60),
                    HttpOnly = true,
                });

               this.HttpContext.Response.Cookies.Append("Auth", JsonSerializer.Serialize(user), new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddSeconds(60),
                    HttpOnly = true,
                });
                this.HttpContext.Response.Redirect("/Home/Index");
            }
            else
            {
                this.HttpContext.Response.Redirect("/Home/Login");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}