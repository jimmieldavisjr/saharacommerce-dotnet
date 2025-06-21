namespace Sahara.API.Models
{
    public class Vendor
    {
        // Primary key and foreign key to the associated User
        public int Id { get; set; }
        public int UserId { get; set; }

        // Basic vendor profile details
        public required string StoreName { get; set; }
        public required string StoreDescription { get; set; }

        // Contact information
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }

        // Current status of the vendor account
        public required VendorStatus Status { get; set; }

        // Navigation: associated User account
        public User User { get; set; }

        // Navigation: products listed by this vendor (nullable)
        public ICollection<Product>? Products { get; set; }
    }
}