using Microsoft.AspNetCore.Mvc;
using Petkit.Models;
using System.Diagnostics;

namespace Petkit.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}