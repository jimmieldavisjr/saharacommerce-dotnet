namespace Sahara.API.Entities
{
    /// <summary>
    /// Represents the current payment status of an order within the system.
    /// </summary>
    public enum PaymentStatus
    {
        /// <summary>
        /// Payment was initiated but not yet completed or confirmed.
        /// </summary>
        Pending,

        /// <summary>
        /// Payment was successfully received and confirmed.
        /// </summary>
        Completed,

        /// <summary>
        /// Payment failed due to an internal error or was declined by the payment provider.
        /// </summary>
        Failed,

        /// <summary>
        /// Payment was returned to a customer by vendor or administrator.
        /// </summary>
        Refunded
    }
}