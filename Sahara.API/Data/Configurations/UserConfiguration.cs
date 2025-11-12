using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sahara.API.Entities;

namespace Sahara.API.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Primary key for the entity.
            builder.HasKey(u => u.Id);

            // Converts the 'Status' enum from default type int, to string for database storage.
            builder.Property(u => u.Role)
                .HasConversion<string>();

            // Query filter to exclude soft-deleted records from all queries by default checking IsDeleted property.
            builder.HasQueryFilter(u => !u.IsDeleted);
        }
    }
}
