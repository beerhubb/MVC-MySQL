using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_MySQL.Controllers
{
    public class HelloworldController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Wellcome(string name, int age)
        {
            ViewData["name"] = "Hello " + name;
            ViewData["age"] = "อายุ " + age;

            return View();
        }
    }
}
