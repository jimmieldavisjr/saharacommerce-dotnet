using System.ComponentModel.DataAnnotations;

namespace Sahara.API.Entities
{
    /// <summary>
    /// Represents a system vendor account, including store information and management capabilities.
    /// </summary>
    public class Vendor
    {
        /// <summary>
        /// Gets or sets the unique identifier of the vendor.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the foreign key identifier linking this vendor to its associated system user account.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the vendor's store name.
        /// </summary>
        [Required]
        public required string StoreName { get; set; }

        /// <summary>
        /// Gets or sets a brief description of the vendor's store.
        /// </summary>
        [Required]
        public required string Description { get; set; }

        /// <summary>
        /// Gets or sets the vendor's store contact number.
        /// </summary>
        [Required]
        public required string PhoneNumber { get; set; }
        
        /// <summary>
        /// Gets or sets the vendor's store address.
        /// </summary>
        [Required]        
        public required string Address { get; set; }

        /// <summary>
        /// Gets or sets the current operational status of the vendor's account (e.g., Active, Suspended, Deleted, etc.).
        /// </summary>
        public VendorStatus Status { get; set; }

        /// <summary>
        /// Navigation property linking this vendor to its associated user account.
        /// </summary>
        public User? User { get; set; }

        /// <summary>
        /// Navigation property representing the collection of products associated with this vendor.
        /// </summary>
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}