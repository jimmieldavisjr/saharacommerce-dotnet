namespace Sahara.API.Entities
{
    public class OrderItem
    {
        // Keys
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        // Order item details
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // Navigation property EF Core
        public Product? Product { get; set; }
        public Order? Order { get; set; }
    }
}
