using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Infrastructure.Configurations;

public class InvoiceTypeConfig : IEntityTypeConfiguration<InvoiceType>
{
    public void Configure(EntityTypeBuilder<InvoiceType> builder)
    {
        builder.Property(it => it.Description).HasMaxLength(100).IsRequired();
    }
}
