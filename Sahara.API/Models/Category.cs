namespace Sahara.API.Models
{
    public class Category
    {
        // Key
        public int Id { get; set; }

        // Name
        public required string Name { get; set; }

        // Navigation property EF Core
        public ICollection<Product>? Products { get; set; }
    }
}
