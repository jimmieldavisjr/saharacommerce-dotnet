using System.ComponentModel.DataAnnotations;

namespace Sahara.API.Models
{
    public class Payment
    {
        // Key
        public int Id { get; set; }
        public int OrderId { get; set; }

        // Payment details
        public decimal Amount { get; set; }

        [Required]
        public required string PaymentMethod { get; set; }

        public DateTime PaymentDate { get; set; }
        public PaymentStatus Status { get; set; }

        // Navigation property EF Core
        public Order? Order { get; set; }
    }
}
