using System.ComponentModel.DataAnnotations;

namespace Sahara.API.Entities
{
    /// <summary>
    /// Represents the category of a product within the system.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets the unique identifier of a category.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        [Required]
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to the collection of products assigned to the category.
        /// </summary>
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
