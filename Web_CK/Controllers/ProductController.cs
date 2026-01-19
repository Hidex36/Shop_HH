using Microsoft.AspNetCore.Mvc;

namespace Web_CK.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
