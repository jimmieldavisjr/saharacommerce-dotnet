namespace Sahara.API.Models
{
    public enum PaymentStatus
    {
        Pending,        // Payment initiated but not yet confirmed
        Completed,      // Payment successfully processed
        Failed,         // Payment was declined or encountered an error
        Refunded        // Payment was returned to the customer
    }
}
