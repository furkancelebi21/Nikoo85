using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace furkii.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Request.Cookies.TryGetValue("User", out string bilgi);
            if (!string.IsNullOrWhiteSpace(bilgi))
            {
                if (bilgi == "furkancelebi@gmail.com:123456")
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Login");
                }
            }

            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(String email, String pw)
        {

            if ($"{email}:{pw}" == "furkancelebi@gmail.com:123456")
            {
                HttpContext.Response.Cookies.Append("User", $"{email}:{pw}");
                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Response.Cookies.Delete("User");
                return RedirectToAction("Login");
            }
            HttpContext.Response.Cookies.Delete("User");
            return RedirectToAction("Login");
        }

    }
}
