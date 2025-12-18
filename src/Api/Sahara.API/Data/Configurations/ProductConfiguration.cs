using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sahara.API.Entities;

namespace Sahara.API.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Primary key.
            builder.HasKey(p => p.Id);

            // Entity relationship with one-to-many mapping and restricted delete behavior.
            builder.HasOne(p => p.Vendor)
                .WithMany(v => v.Products)
                .HasForeignKey(p => p.VendorId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            // Exclude entities marked as deleted from query results.
            builder.HasQueryFilter(p => !p.IsDeleted);

            // Converts enum type integer to string for database storage.
            builder.Property(p => p.Status)
                .HasConversion<string>();

            // Decimal precision for database storage.
            builder.Property(p => p.Price)
                .HasPrecision(18, 2);
        }
    }
}
