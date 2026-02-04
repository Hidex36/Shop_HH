using Microsoft.AspNetCore.Mvc;
using Web_CK.Data;

namespace Web_CK.ViewComponents
{
    public class NewProductsViewComponent : ViewComponent
    {
        readonly AppDbContext _context;
        public NewProductsViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = _context.Products
                .OrderByDescending(p => p.CreatedAt)
                .Take(7)
                .ToList();
            return View(products);
        }
    }
}
