using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OdekuTour.Middlewares;
using System;

namespace OdekuTour.Areas.Admin.Controllers
{
    [Area("admin")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM login)
        {
            if (TokenMiddleware.Login == login.Username && TokenMiddleware.Password == login.Password)
            {
                var options = new CookieOptions
                {
                    Expires = DateTime.MaxValue
                };
                Response.Cookies.Append(TokenMiddleware._key, TokenMiddleware.GetMD5Hash(login.Username, login.Password), options);
                return new ObjectResult(new { Success = true });
            }
            return new ObjectResult(new { Success = false, Message = "Неверный логин или пароль!" });
        }
    }

    public class LoginVM
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}