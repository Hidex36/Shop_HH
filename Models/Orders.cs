namespace Web_CK.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingPhone { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; } // Tổng số tiền của đơn hàng
        public int Status { get; set; } // trạng thái đơn hàng: đang xử lý, đã gửi, đã hủy, v.v.
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
