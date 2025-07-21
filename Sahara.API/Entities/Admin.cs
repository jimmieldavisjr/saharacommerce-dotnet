using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace Sahara.API.Entities
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
        /// Gets or sets the operation status of the admin account.
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// Gets or sets the date and time the admin account was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
