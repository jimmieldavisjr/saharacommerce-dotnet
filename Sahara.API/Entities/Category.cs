using System.ComponentModel.DataAnnotations;

namespace Sahara.API.Entities
{
    public class Category
    {
        // Key
        public int Id { get; set; }

        // Category Name
        [Required]
        public required string Name { get; set; }

        // Navigation property EF Core
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
