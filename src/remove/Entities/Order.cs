using System.ComponentModel.DataAnnotations;

namespace remove.Entities
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
        public int? CustomerId { get; set; }

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

        // ──────────────── Methods ────────────────

        /// <summary>
        /// Sets the order status to <c>Pending</c>.
        /// </summary>
        public void StatusToPending()
        {
            Status = OrderStatus.Pending;
        }

        /// <summary>
        /// Changes the order status from <c>Pending</c> to <c>Processing</c>.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the current status is not <c>Pending</c>.
        /// </exception>
        public void StatusToProcessing()
        {
            if (Status != OrderStatus.Pending)
            {
                throw new InvalidOperationException("Order must be pending to set as processing.");
            }

            Status = OrderStatus.Processing;
        }

        /// <summary>
        /// Changes the order status from <c>Processing</c> to <c>Shipped</c>.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the current status is not <c>Processing</c>.
        /// </exception>
        public void StatusToShipped()
        {
            if (Status != OrderStatus.Processing)
            {
                throw new InvalidOperationException("Order must be processing to set as shipped.");
            }

            Status = OrderStatus.Shipped;
        }

        /// <summary>
        /// Changes the order status from <c>Shipped</c> to <c>Delivered</c>.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the current status is not <c>Shipped</c>.
        /// </exception>
        public void StatusToDelivered()
        {
            if (Status != OrderStatus.Shipped)
            {
                throw new InvalidOperationException("Order must be shipped to set as delivered.");
            }

            Status = OrderStatus.Delivered;
        }

        /// <summary>
        /// Cancels the order if it is not <c>Delivered</c> or <c>Refunded</c>.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the current status is <c>Delivered</c> or <c>Refunded</c>.
        /// </exception>
        public void StatusToCancelled()
        {
            if (Status == OrderStatus.Delivered || Status == OrderStatus.Refunded)
            {
                throw new InvalidOperationException("Delivered or refunded orders cannot be cancelled.");
            }

            Status = OrderStatus.Cancelled;
        }

        /// <summary>
        /// Changes the order status from <c>Delivered</c> to <c>Refunded</c>.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the current status is not <c>Delivered</c>.
        /// </exception>
        public void StatusToRefunded()
        {
            if (Status != OrderStatus.Delivered)
            {
                throw new InvalidOperationException("Order must be delivered to set as refunded.");
            }

            Status = OrderStatus.Refunded;
        }

        /// <summary>
        /// Calculates the total amount of the order.
        /// </summary>
        public void CalculateTotalAmount()
        {
            TotalAmount = OrderItems.Sum(item => item.Quantity * item.UnitPrice);
        }
    }
}