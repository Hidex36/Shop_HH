using Microsoft.AspNetCore.Mvc;
using Web_CK.Data;
using Web_CK.ViewModels;

namespace Web_CK.Controllers
{
    public class ProductController : Controller
    {
        public readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult GetCategoty(int CategoryId)
        {

            //kiem tra CategoryId hop le
            var CategoryProducts = _context.Products
                .Where(p => p.CategoryId == CategoryId)
                .Select(p => new ProductsVM
                {
                    ProductId = p.Id,
                    ProductName = p.Name,
                    CategoryName = p.Category.Name,
                    UnitPrice = p.Price,
                    ImageUrl = p.ImageUrl ?? "",
                });
            return View(CategoryProducts);
        }

        public IActionResult GetDetail(int id)
        {
            //kiem tra  id hop le
            var Products = _context.Products
                .Where(p => p.Id == id)
                .Select(p => new ProductDetailVM
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl ?? "",

                }).FirstOrDefault();
          //them danh sach mau sac va size
            return View(Products);
        }

        public IActionResult  AddToCart(int id, int quanlity)
        {
           
            return RedirectToAction("Index", "Cart");
        }

        public IActionResult Search(string query)
        {
            // Logic to search products can be added here
            return View();
        }

        public IActionResult BuyItem(int id, int quantity)
        {
            // Logic to buy item can be added here
            return RedirectToAction("CheckOut","Cart");
        }

        public IActionResult getAllProduct()
        {

            return View();
        }


    }
}
