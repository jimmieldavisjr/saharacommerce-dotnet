using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sahara.API.Entities;

namespace Sahara.API.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Primary key.
            builder.HasKey(c => c.Id);

            // Exclude entities marked as deleted from query results.
            builder.HasQueryFilter(c => !c.IsDeleted);
        }
    }
}
