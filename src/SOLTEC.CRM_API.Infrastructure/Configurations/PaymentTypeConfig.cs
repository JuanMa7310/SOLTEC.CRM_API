using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Infrastructure.Configurations;

public class PaymentTypeConfig : IEntityTypeConfiguration<PaymentType>
{
    public void Configure(EntityTypeBuilder<PaymentType> builder)
    {
        // Configuración de la clave primaria
        builder.HasKey(pt => pt.Id);

        // Propiedades heredadas de BaseEntity
        builder.Property(pt => pt.CreatedBy).HasMaxLength(256);
        builder.Property(pt => pt.UpdatedBy).HasMaxLength(256);
        builder.Property(pt => pt.CreatedAt).IsRequired();
        builder.Property(pt => pt.UpdatedAt).IsRequired(false);

        // Propiedades específicas de Address
        builder.Property(pt => pt.Description).HasMaxLength(100).IsRequired();
    }
}
