using System.ComponentModel.DataAnnotations;

namespace Sahara.API.Models
{
    public class User
    {
        // Key
        public int Id { get; set; }

        // Authentification
        [Required]
        public required string Email { get; set; }

        [Required]
        public required string PasswordHash { get; set; }

        // Users legal name
        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        // User account role
        public UserRole Role { get; set; }

        // Navigation property EF Core
        public Vendor? VendorProfile { get; set; }
        public Customer? CustomerProfile { get; set; }
    }
}
