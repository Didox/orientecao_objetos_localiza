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
    [Route("/Login")]
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        
    }
}