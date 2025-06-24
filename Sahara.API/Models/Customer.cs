namespace Sahara.API.Models
{
    public class Customer
    {
        // Key
        public int Id { get; set; }
        public int UserId { get; set; }

        // Accumulated reward points
        public int Points { get; set; }

        // Status
        public CustomerStatus Status{ get; set; }

        // Navigation property EF Core
        public User? User { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
