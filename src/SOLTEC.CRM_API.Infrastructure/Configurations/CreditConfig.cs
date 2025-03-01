using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Infrastructure.Configurations;

public class CreditConfig : IEntityTypeConfiguration<Credit>
{
    public void Configure(EntityTypeBuilder<Credit> builder)
    {
        // Configuración de la clave primaria
        builder.HasKey(c => c.Id);

        // Propiedades heredadas de BaseEntity
        builder.Property(c => c.CreatedBy).HasMaxLength(256);
        builder.Property(c => c.UpdatedBy).HasMaxLength(256);
        builder.Property(c => c.CreatedAt).IsRequired();
        builder.Property(c => c.UpdatedAt).IsRequired(false);

        // Propiedades específicas de Address
        builder.Property(c => c.TotalAmount).HasColumnType("decimal(18,2)").IsRequired();
        builder.Property(c => c.UsedAmount).HasColumnType("decimal(18,2)").IsRequired();
    }
}
