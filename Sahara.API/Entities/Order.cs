using System.ComponentModel.DataAnnotations;

namespace Sahara.API.Entities
{
    /// <summary>
    /// Represents the details of an order within the system.
    /// </summary>
    public class Order
    {
        // ──────────────── Properties ────────────────

        /// <summary>
        /// Gets or sets the unique identifier of the order.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the foreign key identifier of the customer associated with the order.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the foreign key identifier of the payment associated with the order.
        /// </summary>
        public int PaymentId { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the order was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the current status of the order.
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the total amount of the order.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the shipping address for the order.
        /// </summary>
        [Required]
        public required string ShippingAddress { get; set; }

        /// <summary>
        /// Gets or sets the billing address for the order.
        /// </summary>
        [Required]
        public required string BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to the associated customer.
        /// </summary>
        public Customer? Customer { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to the associated payment.
        /// </summary>
        public Payment? Payment { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to the collection of items included in the order.
        /// </summary>
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}