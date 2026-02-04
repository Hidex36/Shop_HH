namespace Web_CK.Models
{
    public class Carts
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public Users User { get; set; }
        public int ProductId { get; set; }
        public Products Product { get; set; }

        // Số lượng sản phẩm
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}


//session cart khong luu db _ ham getcerrentuserid()