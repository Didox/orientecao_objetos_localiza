using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

        public IActionResult Privacy(int time = 0)
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }

        public void Logar()
        {
            string login = this.HttpContext.Request.Form["login"];
            string password = this.HttpContext.Request.Form["password"];
            if (login != null)
            {
                this.HttpContext.Response.Cookies.Append("Logado", "true", new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddSeconds(6000),
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