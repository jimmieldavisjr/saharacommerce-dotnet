namespace Sahara.API.Entities
{
    /// <summary>
    /// Represents the details of an individual item within an order in the system.
    /// </summary>
    public class OrderItem
    {
        // ──────────────── Properties ────────────────

        /// <summary>
        /// Gets or sets the unique identifier for the item.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the foreign key identifier of the product associated with this item.
        /// </summary>
        public int? ProductId { get; set; }

        /// <summary>
        /// Gets or sets the foreign key identifier of the order associated with this item.
        /// </summary>
        public int? OrderId { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the product included in the order.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit price of the product at time of purchase.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to the associated product.
        /// </summary>
        public Product? Product { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to the associated order.
        /// </summary>
        public Order? Order { get; set; }
    }
}