namespace Web_CK.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Orders Order { get; set; }

        public int ProductId { get; set; }
        public Products Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }//gia cua san pham
    }
}
