using Microsoft.AspNetCore.Mvc;
using Web_CK.Data;

namespace Web_CK.Controllers
{
    public class CartController : Controller
    {
        public readonly AppDbContext _context;
        public CartController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetCheckout()
        {
            return View();
        }

        public IActionResult RemoveItem(int id)
        {
            // Logic to remove item from cart can be added here
            return RedirectToAction("Index");
        }

        public IActionResult UpdateQuantity(int id, int quantity)
        {
            // Logic to update item quantity in cart can be added here
            return RedirectToAction("Index");
        }
        public IActionResult ClearCart()
        {
            // Logic to clear the cart can be added here
            return RedirectToAction("Index");
        }

        public IActionResult ThankYou()
        {
            return View();
        }

        // POST: /Cart/payment
        [HttpPost]
        public IActionResult Payment()
        {
            return RedirectToAction("ThankYou");
        }

    }
}
