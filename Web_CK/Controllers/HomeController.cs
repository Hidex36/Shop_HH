using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CK.Models;

namespace Web_CK.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }


        public IActionResult About()
        {
            return View("About");
        }
    }
}
