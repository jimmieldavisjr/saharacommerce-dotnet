using System.ComponentModel.DataAnnotations;

namespace Sahara.API.Entities
{
    /// <summary>
    /// Represents a product offered for sale within the system.
    /// </summary>
    public class Product
    {
        // ──────────────── Properties ────────────────

        /// <summary>
        /// Gets or sets the unique identifier of the product.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the foreign key identifier of the vendor associated with this product.
        /// </summary>
        public int? VendorId { get; set; }

        /// <summary>
        /// Gets or sets the foreign key identifier of the category associated with this product.
        /// </summary>
        public int? CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the operation status of the product.
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        [Required]
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        [Required]
        public required string Description { get; set; }

        /// <summary>
        /// Gets or sets the current price of the product.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the current stock quantity of the product.
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// Gets or sets the current status of the product.
        /// </summary>
        public ProductStatus Status{ get; set; }

        /// <summary>
        /// Navigation property that references the category this product belongs to.
        /// </summary>
        public Category? Category { get; set; }

        /// <summary>
        /// Navigation property that references the vendor that owns this product.
        /// </summary>
        public Vendor? Vendor { get; set; }

        // ──────────────── Methods ────────────────

        /// <summary>
        /// Changes the current status of the product to active.
        /// </summary>
        public void StatusToActive()
        {
            Status = ProductStatus.Active;
        }

        /// <summary>
        /// Changes the current status of the product to inactive.
        /// </summary>
        public void StatusToInactive()
        {
            Status = ProductStatus.Inactive;
        }

        /// <summary>
        /// Changes and updates the current product details.
        /// </summary>
        /// <param name="name">The updated product name.</param>
        /// <param name="description">The updated product description.</param>
        /// <param name="price">The updated product price.</param>
        /// <param name="stock">The updated product stock.</param>
        public void UpdateProductInformation(string name, string description, decimal price, int stock)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
        }
    }
}