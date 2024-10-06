using ex4_1MovieList.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ex4_1MovieList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
