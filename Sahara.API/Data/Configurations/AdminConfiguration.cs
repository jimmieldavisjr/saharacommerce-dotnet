using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sahara.API.Entities;

namespace Sahara.API.Data.Configurations
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            // Primary key for the entity.

            builder.HasKey(a => a.Id);

            // Entity relationship: one-to-one mapping between Admin and User with restricted delete behavior.

            builder.HasOne(a => a.User)
                .WithOne(u => u.Admin)
                .HasForeignKey<Admin>(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            // Converts the 'Status' enum from default type int, to string for database storage.

            builder.Property(a => a.Status)
                .HasConversion<string>();

            // Exclude entities marked as deleted from query results.

            builder.HasQueryFilter(a => !a.IsDeleted);
        }
    }
}
