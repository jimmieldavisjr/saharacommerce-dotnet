using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Sahara.API.Entities;

namespace Sahara.API.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            // Primary key.
            builder.HasKey(o => o.Id);

            // Entity relationship with one-to-many mapping and restricted delete behavior.
            builder.HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            // Converts enum type integer to string for database storage.
            builder.Property(o => o.Status)
                .HasConversion<string>();

            // Decimal precision for database storage.
            builder.Property(o => o.TotalAmount)
                .HasPrecision(18, 2);
        }
    }
}
