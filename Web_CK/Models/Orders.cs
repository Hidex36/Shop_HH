using System.ComponentModel.DataAnnotations.Schema;

namespace Web_CK.Models
{
    public class Orders
    {
        public int Id { get; set; }

        public string UserId { get; set; } 

        public DateTime OrderDate { get; set; } = DateTime.Now; 

        public int OrderStatus { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }
        public virtual ICollection<OrderDetails> Details { get; set; }
    }
}
