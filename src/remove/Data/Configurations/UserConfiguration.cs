using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using remove.Entities;

namespace remove.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Primary key.
            builder.HasKey(u => u.Id);

            // Converts enum type integer to string for database storage.
            builder.Property(u => u.Role)
                .HasConversion<string>();

            // Exclude entities marked as deleted from query results.
            builder.HasQueryFilter(u => !u.IsDeleted);
        }
    }
}
