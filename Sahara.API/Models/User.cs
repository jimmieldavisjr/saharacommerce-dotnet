namespace Sahara.API.Models
{
    public class User
    {
        // Keys and authentification
        public int Id { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }

        // Users legal name
        public required string FirstName { get; set; }  
        public required string LastName { get; set; }

        // User account role
        public required UserRole Role { get; set; }

        // Navigation property EF Core
        public Vendor? VendorProfile { get; set; }
        public Customer? CustomerProfile { get; set; }
    }
}
