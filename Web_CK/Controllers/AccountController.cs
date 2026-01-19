using Microsoft.AspNetCore.Mvc;

namespace Web_CK.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
