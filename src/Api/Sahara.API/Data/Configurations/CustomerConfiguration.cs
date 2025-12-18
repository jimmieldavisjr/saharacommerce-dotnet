using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sahara.API.Entities;

namespace Sahara.API.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // Primary key.
            builder.HasKey(c => c.Id);

            // Entity relationship with one-to-one mapping and restricted delete behavior.
            builder.HasOne(c => c.User)
                .WithOne(u => u.Customer)
                .HasForeignKey<Customer>(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            // Converts enum type integer to string for database storage.
            builder.Property(c => c.Status)
                .HasConversion<string>();

            // Exclude entities marked as deleted from query results.
            builder.HasQueryFilter(c => !c.IsDeleted);
        }
    }
}
