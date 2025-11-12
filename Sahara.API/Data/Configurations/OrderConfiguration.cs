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
            // Primary key for the entity.
            builder.HasKey(o => o.Id);

            // Configures a required one-to-one relationship between Admin and User with restricted delete behavior.
            builder.HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            // Converts the 'Status' enum form default type int, to string for database storage.
            builder.Property(o => o.Status);

            // Decimal precision for database storage
            builder.Property(o => o.TotalAmount)
                .HasPrecision(18, 2);
        }
    }
}
