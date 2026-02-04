using Microsoft.AspNetCore.Mvc;
using Web_CK.Data;

namespace Web_CK.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        readonly AppDbContext _context;
        public CategoryListViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(string TypeOfCategory)
        {
            var categories = _context.Categories
                .OrderBy(c => c.Name)
                .ToList();
            return View(TypeOfCategory,categories);
        }
    }
}
