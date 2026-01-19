using Microsoft.AspNetCore.Mvc;

namespace Web_CK.Controllers
{
    public class WishListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
