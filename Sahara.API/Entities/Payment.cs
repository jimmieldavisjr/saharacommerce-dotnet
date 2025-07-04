using System.ComponentModel.DataAnnotations;

namespace Sahara.API.Entities
{
    /// <summary>
    /// Represents the payment details associated with an order in the system.
    /// </summary>
    public class Payment
    {
        // ──────────────── Properties ────────────────

        /// <summary>
        /// Gets or sets the unique identifier for the payment.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the foreign key identifier of the order associated with the payment.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the total payment amount.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the method used to make the payment (e.g., Credit Card, PayPal).
        /// </summary>
        [Required]
        public required string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets the date the payment was made.
        /// </summary>
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Gets or sets the current status of the payment.
        /// </summary>
        public PaymentStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to the associated order.
        /// </summary>
        public Order? Order { get; set; }
    }
}
