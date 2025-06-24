using System.ComponentModel.DataAnnotations;

namespace Sahara.API.Models
{
    public class Product
    {
        // Keys
        public int Id { get; set; } 
        public int VendorId { get; set; }
        public int CategoryId { get; set; }

        // Product Info
        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Description { get; set; }

        // Pricing & Stock
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // Navigation property EF Core
        public Category? Category { get; set; }
        public Vendor? Vendor { get; set; }
    }
}