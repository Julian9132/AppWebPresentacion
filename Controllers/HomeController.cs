using AppBootstrap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace AppBootstrap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("Denegado")]
        public IActionResult Denegado()
        {
            return View();
        }



        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Nosotros()
        {
            return View();
        }
        [Authorize]
        public IActionResult Welcome()
        {
            return View();
        }

        [Authorize(Roles ="usuario")]
        public IActionResult Eventos()
        {
            return View();
        }


        //-----------------------------------AUTENTICACION-----------------------------------------------
        [HttpGet("Login")]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost("Login")]

        public async Task<IActionResult> validar(string username, string password, string returnUrl)
        {
            // lectura de la base de datos

            var db = new netsenaContext();
            var usuarioLogeado = db.Usuario.FirstOrDefault(u => u.apodo == username && u.clave == password );

           // if (username=="Naroo" && password == "jjjj")
           if(usuarioLogeado != null)
            {
                var claims = new List<Claim>();
                claims.Add(new Claim("username", username));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, username));
                claims.Add(new Claim(ClaimTypes.Name, usuarioLogeado.nombre));
                claims.Add(new Claim(ClaimTypes.Role, usuarioLogeado.Rol));
                var ClaimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var ClaimsPrincipal = new ClaimsPrincipal(ClaimsIdentity);
                await HttpContext.SignInAsync(ClaimsPrincipal);

                return Redirect(returnUrl);

            }
            else
            {
                ViewData["ReturnUrl"] = returnUrl;
                TempData["Error"] = "El ususario o la contraseña no son validos";
                return View("Login");

            }
        }
        //-----------------------------------FIN AUTENTICACION-----------------------------------------------

        [Authorize]
        
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
