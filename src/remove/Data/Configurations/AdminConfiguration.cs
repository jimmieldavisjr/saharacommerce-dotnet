using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using remove.Entities;

namespace remove.Data.Configurations
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            // Primary key.
            builder.HasKey(a => a.Id);

            // Entity relationship with one-to-one mapping and restricted delete behavior.
            builder.HasOne(a => a.User)
                .WithOne(u => u.Admin)
                .HasForeignKey<Admin>(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            // Converts enum type integer to string for database storage.
            builder.Property(a => a.Status)
                .HasConversion<string>();

            // Exclude entities marked as deleted from query results.
            builder.HasQueryFilter(a => !a.IsDeleted);
        }
    }
}
