using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_login.Models;


namespace mvc_login.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [Route("/Login")]
        public void EfetuarLogin(){
            this.HttpContext.Response.Cookies
                .Append("User",
                new CookieOptions {
                    Expires = DateTimeOffset.UtcNow.AddSeconds(15),
                    HttpOnly = true
                });
            this.HttpContext.Response.Redirect("/");
        }
}
}