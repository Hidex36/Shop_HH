using System.ComponentModel.DataAnnotations.Schema;

namespace Web_CK.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Categories? Category { get; set; }
    }
}
