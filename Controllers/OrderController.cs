using Microsoft.AspNetCore.Mvc;

namespace Web_CK.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
