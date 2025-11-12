using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sahara.API.Entities;

namespace Sahara.API.Data.Configurations
{
    public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            // Primary key for the entity.
            builder.HasKey(v => v.Id);

            // Entity Relationship: one-to-one mapping between Vendor and User entities with restricted delete behavior.
            builder.HasOne(v => v.User)
                .WithOne(u => u.Vendor)
                .HasForeignKey<Vendor>(v => v.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            // Concerts the 'Status' enum from default type int, to string for database storage.
            builder.Property(v => v.Status)
                .HasConversion<string>();

            // Exclude entities marked as deleted from query results.
            builder.HasQueryFilter(v => !v.IsDeleted);
        }
    }
}
