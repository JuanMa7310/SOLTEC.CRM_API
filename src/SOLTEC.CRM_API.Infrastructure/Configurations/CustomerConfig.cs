using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Infrastructure.Configurations;

public class CustomerConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.Property(c => c.Name).HasMaxLength(255).IsRequired();
        builder.Property(c => c.TaxId).HasMaxLength(50).IsRequired();
    }
}
