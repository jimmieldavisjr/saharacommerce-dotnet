using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sahara.API.Entities;

namespace Sahara.API.Data.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            // Primary key.
            builder.HasKey(oi => oi.Id);

            // Entity relationship with one-to-many mapping and restricted delete behavior.
            builder.HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            // Entity relationship with one-to-many mapping and restricted delete behavior.
            builder.HasOne(oi => oi.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(oi => oi.ProductId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);
            
            // Decimal precision for database storage.
            builder.Property(oi => oi.UnitPrice)
                .HasPrecision(18, 2);
        }
    }
}
