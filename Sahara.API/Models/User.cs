using System.ComponentModel.DataAnnotations;
using Sahara.API.Helpers;

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




        // Update users profile: first and last name
        public void UpdateProfile(string firstName, string lastName)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("First name cannot be empty.", nameof(firstName));
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Last name cannot be empty.", nameof(lastName));
            
            }

            // Sanitize input
            firstName = firstName.Trim();
            lastName = lastName.Trim();

            // Update properties
            FirstName = firstName;
            LastName = lastName;
        }

        // Change users current email address
        public void ChangeEmail(string newEmail)
        {
            // Validate input
            if(string.IsNullOrWhiteSpace(newEmail))
            {
                throw new ArgumentException("Email address cannot be empty.", nameof(newEmail));
            }

            if (!EmailValidator.IsValidEmailFormat(newEmail))
            {
                throw new ArgumentException("Email is not in valid format.", nameof(newEmail));
            }

            // Sanitize input
            newEmail = newEmail.Trim().ToLowerInvariant();

            // Update properties
            Email = newEmail;
        }
    }
}