using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using remove.Entities;

namespace remove.Data.Configurations
{
    public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            // Primary key.
            builder.HasKey(v => v.Id);

            // Entity relationship with one-to-one mapping and restricted delete behavior.
            builder.HasOne(v => v.User)
                .WithOne(u => u.Vendor)
                .HasForeignKey<Vendor>(v => v.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            // Converts enum type integer to string for database storage.
            builder.Property(v => v.Status)
                .HasConversion<string>();

            // Exclude entities marked as deleted from query results.
            builder.HasQueryFilter(v => !v.IsDeleted);
        }
    }
}
