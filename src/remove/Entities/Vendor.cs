using System.ComponentModel.DataAnnotations;

namespace remove.Entities
{
    /// <summary>
    /// Represents the vendor account within the system.
    /// </summary>
    public class Vendor
    {
        // ──────────────── Properties ────────────────

        /// <summary>
        /// Gets or sets the unique identifier of the vendor.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the foreign key identifier of the user associated with the vendor.
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or sets the operation status of the vendor.
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// Gets or sets the vendor's store name.
        /// </summary>
        [Required]
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets a brief description of the vendor's store.
        /// </summary>
        [Required]
        public required string Description { get; set; }

        /// <summary>
        /// Gets or sets the vendor's store contact number.
        /// </summary>
        [Required]
        public required string Phone { get; set; }

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

        // ──────────────── Methods ────────────────

        /// <summary>
        /// Changes the current status of the vendor to Maintenance (temporary).
        /// </summary>
        public void StatusToMaintenance()
        {
            Status = VendorStatus.Maintenance;
        }

        /// <summary>
        /// Changes the current status of the vendor to Closed (temporarily closed).
        /// </summary>
        public void StatusToClosed()
        {
            Status = VendorStatus.Closed;
        }

        /// <summary>
        /// Changes and updates the current vendor details.
        /// </summary>
        /// <param name="name">The updated vendor name.</param>
        /// <param name="description">The updated vendor description</param>
        /// <param name="phone">The updated vendor phone number.</param>
        /// <param name="address">The updated vendor business address.</param>
        public void UpdateBusinessInformation(string name, string description, string phone, string address)
        {
            Name = name;
            Description = description;
            Phone = phone;
            Address = address;
        }
    }
}