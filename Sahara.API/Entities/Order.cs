using System.ComponentModel.DataAnnotations;

namespace Sahara.API.Entities
{
    public class Order
    {
        // Keys
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }

        // Order Metadata
        public DateTime CreatedAt { get; set; }
        public OrderStatus Status { get; set; }

        // Payment and Address Info
        public decimal TotalAmount { get; set; }

        [Required]
        public required string ShippingAddress { get; set; }

        [Required]
        public required string BillingAddress { get; set; }

        // Navigation property EF Core
        public Customer? Customer { get; set; }
        public Payment? Payment { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
    }
}