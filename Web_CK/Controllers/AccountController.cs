using Microsoft.AspNetCore.Mvc;

namespace Web_CK.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUP()
        {
            return View();
        }
    }
}
