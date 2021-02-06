using LoginWithCookies.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc.Filters;

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
        public IActionResult Login(Login obj)
        {
            if (!String.IsNullOrEmpty(obj.Usuario) && !String.IsNullOrEmpty(obj.Senha))
            {
                this.HttpContext.Response.Cookies.Append(obj.Usuario, Convert.ToBase64String(Encoding.ASCII.GetBytes(obj.Senha)), new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddSeconds(3600),
                    HttpOnly = true,

                });

                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpGet]
        [AcaoComAutorizacao]
        public IActionResult Index()
        {

            ViewBag.CookieValue = string.Empty;
            if (this.HttpContext.Request.Cookies.Keys.Count > 0)
            {
                foreach (var httpCon in HttpContext.Request.Cookies)
                {
                    ViewBag.CookieValue += $@"Chave: {httpCon.Key} - Valor: {httpCon.Value} - ";
                }
            }

            return View();
        }

        [HttpGet]
        [AcaoComAutorizacao]
        public IActionResult Privacy()
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
