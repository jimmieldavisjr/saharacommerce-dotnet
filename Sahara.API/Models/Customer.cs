namespace Sahara.API.Models
{
    public class Customer
    {
        // Primary Key
        public int Id { get; set; }

        // Foreign Key reference to User
        public int UserId { get; set; }

        // Accumulated reward or discount points
        public int Points { get; set; }

        // Navigation to the associated User account
        public User User { get; set; }

        // Orders placed by this customer
        public ICollection<Order> Orders { get; set; }
    }
}
