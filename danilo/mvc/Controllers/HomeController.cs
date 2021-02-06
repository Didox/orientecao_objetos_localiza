using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc.Models;
using Microsoft.AspNetCore.Http;
using mvc.Infra;

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
            ViewBag.valorSessao = this.HttpContext.Request.Cookies["Alunos"];

            return View();
        }

        public IActionResult Privacy(int time = 0)
        {
            if(time > 0)
            {
                this.HttpContext.Response.Cookies.Append("Alunos", "Localiza", new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddSeconds(time),
                    HttpOnly = true,
                });
            }


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
