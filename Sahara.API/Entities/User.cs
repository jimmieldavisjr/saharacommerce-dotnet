using System;
using System.ComponentModel.DataAnnotations;
using Sahara.API.Helpers;

namespace Sahara.API.Entities
{
    /// <summary>
    /// Represents the user account within the system.
    /// </summary>
    public class User
    {
        // ──────────────── Properties ────────────────

        /// <summary>
        /// Gets or sets the unique identifier of the user.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the email address used for authentication.
        /// </summary>
        [Required]
        public required string Email { get; set; }

        /// <summary>
        /// Gets or sets the hashed password for authentication.
        /// </summary>
        [Required]
        public required string PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets the user's legal first name.
        /// </summary>
        [Required]
        public required string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the user's legal last name.
        /// </summary>
        [Required]
        public required string LastName { get; set; }

        /// <summary>
        /// Gets or sets the role defining the user's system access level.
        /// </summary>
        public UserRole Role { get; set; }

        /// <summary>
        /// Navigation property to the associated vendor profile if the user is a vendor.
        /// </summary>
        public Vendor? VendorProfile { get; set; }

        /// <summary>
        /// Navigation property to the associated customer profile if the user is a customer.
        /// </summary>
        public Customer? CustomerProfile { get; set; }

        // ──────────────── Methods ────────────────

        /// <summary>
        /// Changes the user's profile with the specified first and last name.
        /// Throws <see cref="ArgumentException"/> if the names are empty or whitespace.
        /// </summary>
        /// <param name="firstName">The new first name.</param>
        /// <param name="lastName">The new last name.</param>
        public void ChangeProfile(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name cannot be empty.", nameof(firstName));
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Last name cannot be empty.", nameof(lastName));

            FirstName = firstName.Trim();
            LastName = lastName.Trim();
        }

        /// <summary>
        /// Changes the user's current email address.
        /// Throws if the email is invalid.
        /// </summary>
        /// <param name="email">The updated user email address.</param>
        public void ChangeEmail(string email)
        {
            var validatedEmail = EmailValidator.Validate(email);
            Email = validatedEmail;
        }

        /// <summary>
        /// Changes the user's password.
        /// Throws if the password is invalid.
        /// </summary>
        /// <param name="password">The updated user password.</param>
        public void ChangePassword(string password)
        {
            var validatedPassword = PasswordValidator.Validate(password);
            PasswordHash = validatedPassword;
        }
    }
}
