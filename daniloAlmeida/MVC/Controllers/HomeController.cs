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
using MVC.Models;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;

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

        [HttpPost]
        public IActionResult Login(Usuario _user)
        {
            var user = new Usuario();

            if (_user.Nome == user.GetUsuario().Nome && _user.Senha == user.GetUsuario().Senha)
            {
                var usuario = Serializar<Usuario>(_user);

                this.HttpContext.Response.Cookies.Append("Login", usuario, new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddSeconds(1000),
                    HttpOnly = true,
                });
                return Redirect("/");
            }

            //ViewBag.error("Login ou senha invalidos");        
            return View("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public static string Serializar<T>(T obj)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            serializer.WriteObject(ms, obj);
            return Encoding.UTF8.GetString(ms.ToArray());
        }
    }
}
