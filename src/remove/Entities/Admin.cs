using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace remove.Entities
{
    /// <summary>
    /// Represents the admin account within the system.
    /// </summary>
    public class Admin
    {
        // ──────────────── Properties ────────────────

        /// <summary>
        /// Gets or sets the unique identifier of the admin.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the foreign key identifier of the user associated with the admin.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the operation status of the admin account.
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// Gets or sets the email address for authentication.
        /// </summary>
        [Required]
        public required string Email { get; set; }

        /// <summary>
        /// Gets or sets the hashed password for authentication.
        /// </summary>
        [Required]
        public required string PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets the date and time the admin account was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the operational status of an admin's account.
        /// </summary>
        public AdminStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to the associated user account.
        /// </summary>
        public User User { get; set; }
    }
}
