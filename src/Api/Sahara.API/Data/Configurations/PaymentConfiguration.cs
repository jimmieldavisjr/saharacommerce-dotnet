using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sahara.API.Entities;

namespace Sahara.API.Data.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            // Primary key.
            builder.HasKey(p => p.Id);

            // Entity relationship with one-to-one mapping and restricted delete behavior.
            builder.HasOne(p => p.Order)
                .WithOne(o => o.Payment)
                .HasForeignKey<Payment>(p => p.OrderId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            // Converts enum type integer to string for database storage.
            builder.Property(p => p.Status)
                .HasConversion<string>();

            // Decimal precision for database storage.
            builder.Property(p => p.Amount)
                .HasPrecision(18, 2);
        }
    }
}