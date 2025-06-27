namespace Sahara.API.Entities
{
    public enum OrderStatus
    {
        Pending,        // Order created but not yet processed
        Processing,     // Payment confirmed and order is being prepared
        Shipped,        // Order sent to customer
        Delivered,      // Order successfully delivered to customer
        Cancelled,      // Order cancelled before shipping
        Refunded        // Order refunded after cancellation or return
    }
}
