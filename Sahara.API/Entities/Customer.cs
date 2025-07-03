namespace Sahara.API.Entities
{
    /// <summary>
    /// Represents the customer account within the system.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the unique identifier of the customer.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the foreign key identifier of the user associated with the customer.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the total reward points accrued from purchases.
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        /// Gets or sets the current operational status of the customer account.
        /// </summary>
        public CustomerStatus Status{ get; set; }

        /// <summary>
        /// Gets or sets the navigation property to the associated user account.
        /// </summary>
        public User? User { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to the collection of orders associated with the customer.
        /// </summary>
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
