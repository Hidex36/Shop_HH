namespace Web_CK.Models
{
    public class Carts
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual Users? User { get; set; }
        public int ProductId { get; set; }
        public virtual Products? Product { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
