using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Infrastructure.Configurations;

public class CustomerConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.CreatedBy).HasMaxLength(256);
        builder.Property(c => c.UpdatedBy).HasMaxLength(256);
        builder.Property(c => c.CreatedAt).IsRequired();
        builder.Property(c => c.UpdatedAt).IsRequired(false);

        builder.Property(c => c.Name).HasMaxLength(255).IsRequired();
        builder.Property(c => c.TaxId).HasMaxLength(50).IsRequired();

        builder.HasOne(c => c.PrimaryContact)
               .WithMany()
               .HasForeignKey(c => c.PrimaryContactId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.Address)
               .WithMany()
               .HasForeignKey(c => c.AddressId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
