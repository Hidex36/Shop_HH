using Microsoft.AspNetCore.Mvc;

namespace Web_CK.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
