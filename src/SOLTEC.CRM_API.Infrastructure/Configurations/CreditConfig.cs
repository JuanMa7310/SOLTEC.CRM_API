using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Infrastructure.Configurations;

public class CreditConfig : IEntityTypeConfiguration<Credit>
{
    public void Configure(EntityTypeBuilder<Credit> builder)
    {
        builder.Property(c => c.TotalAmount).HasColumnType("decimal(18,2)").IsRequired();
        builder.Property(c => c.UsedAmount).HasColumnType("decimal(18,2)").IsRequired();
    }
}
