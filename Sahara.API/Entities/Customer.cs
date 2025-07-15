namespace Sahara.API.Entities
{
    /// <summary>
    /// Represents the customer account within the system.
    /// </summary>
    public class Customer
    {
        // ──────────────── Properties ────────────────

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

        // ──────────────── Methods ────────────────

        /// <summary>
        /// Adds reward points to the customer account.
        /// </summary>
        /// <param name="points">Number of points to be added to customer account.</param>
        /// <exception cref="ArgumentOutOfRangeException">Throws exception if the the points being added is not greater than 0.</exception>
        public void AccumulatePoints(int points)
        {
            if (points <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(points), "Points must be greater than 0 to be accumulated.");
            }
            else
            {
                Points += points;
            }
        }

        /// <summary>
        /// Changes the current status of the customer to Deleted (soft-deleted).
        /// </summary>
        public void StatusToDeleted()
        {
            Status = CustomerStatus.Deleted;
        }
    }
}
