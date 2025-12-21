using System;
using System.ComponentModel.DataAnnotations;
using Sahara.API.Helpers;

namespace Sahara.Modules.Users.Domain.Entities
{
    /// <summary>
    /// Represents the user account within the system.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the unique identifier of the user.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the operation status of the user.
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// Gets or sets the user's legal first name.
        /// </summary>
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the user's legal last name.
        /// </summary>
        public string LastName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the role defining the user's system access level.
        /// </summary>
        public UserRole Role { get; set; }

        /// <summary>
        /// Navigation property to the associated vendor profile if the user is a vendor.
        /// </summary>
        public Vendor? Vendor { get; set; }

        /// <summary>
        /// Navigation property to the associated customer profile if the user is a customer.
        /// </summary>
        public Customer? Customer { get; set; }

        /// <summary>
        /// Navigation Property to the associated admin profile if the user is an admin.
        /// </summary>
        public Admin? Admin { get; set; }
    }
}
