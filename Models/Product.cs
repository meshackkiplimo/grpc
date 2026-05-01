using System.ComponentModel.DataAnnotations;

namespace  ProductGrpc.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public  required string Name { get; set; }
        public required string Description { get; set; }

        public decimal Price { get; set; }
       public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
       public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
       public string? Tags {get; set;}
    }
}