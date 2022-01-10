using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace furkii.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index(String email,String pw)
        {

            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
