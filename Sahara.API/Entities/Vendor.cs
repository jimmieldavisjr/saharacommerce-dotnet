using System.ComponentModel.DataAnnotations;

namespace Sahara.API.Entities
{
    /// <summary>
    /// Represents the vendor account within the system.
    /// </summary>
    public class Vendor
    {
        /// <summary>
        /// Gets or sets the unique identifier of the vendor.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the foreign key identifier of the user associated with the vendor.
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
        /// Gets or sets the current operational status of the vendor's account.
        /// </summary>
        public VendorStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to the vendor's user account.
        /// </summary>
        public User? User { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to the collection of products associated with the vendor.
        /// </summary>
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}