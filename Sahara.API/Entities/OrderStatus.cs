namespace Sahara.API.Entities
{
    /// <summary>
    /// Represents the current status of an order within the system.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Order has been created but not yet processed.
        /// </summary>
        Pending,

        /// <summary>
        /// Payment is confirmed and order is being prepared.
        /// </summary>
        Processing,

        /// <summary>
        /// Order has been shipped to customer.
        /// </summary>
        Shipped,

        /// <summary>
        /// Order has been successfully delivered to customer.
        /// </summary>
        Delivered,      

        /// <summary>
        /// Order has been canceled before shipping.
        /// </summary>
        Cancelled,      

        /// <summary>
        /// Order has been refunded after cancellation or return.
        /// </summary>
        Refunded        
    }
}
