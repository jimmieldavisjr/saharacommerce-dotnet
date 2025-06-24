using System.ComponentModel.DataAnnotations;

namespace Sahara.API.Models
{
    public class Vendor
    {
        // Primary key and foreign key to the associated User
        public int Id { get; set; }
        public int UserId { get; set; }

        // Basic vendor profile details
        [Required]
        public required string StoreName { get; set; }

        [Required]
        public required string Description { get; set; }

        // Contact information
        [Required]
        public required string PhoneNumber { get; set; }
        
        [Required]        
        public required string Address { get; set; }

        // Current status of the vendor account
        public VendorStatus Status { get; set; }

        // Navigation property EF Core
        public User? User { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}