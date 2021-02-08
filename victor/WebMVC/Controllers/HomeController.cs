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

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Autenticacao]
        public IActionResult Index()
        {
            return View();
        }

        [Autenticacao]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [Autenticacao, Autorizacao(perfil = TipoDeAcesso.ADMIN)]
        public IActionResult Admin()
        {
            return View();
        }

        [Autenticacao, Autorizacao(perfil = TipoDeAcesso.USUARIO)]
        public IActionResult Usuario()
        {
            return View();
        }

        [Autenticacao]
        public IActionResult Autorizacao()
        {
            return View();
        }

        [
            ResponseCache(
                Duration = 0,
                Location = ResponseCacheLocation.None,
                NoStore = true)
        ]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
