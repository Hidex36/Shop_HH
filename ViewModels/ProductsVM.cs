namespace Web_CK.ViewModels
{
    public class ProductsVM
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
        public string  ImageUrl { get; set; }


    }

    public class ProductDetailVM
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int quantity { get; set; }
    }
}
