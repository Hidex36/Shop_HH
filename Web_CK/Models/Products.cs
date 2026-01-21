namespace Web_CK.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Prices { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public Categories Category { get; set; }
    }
}
