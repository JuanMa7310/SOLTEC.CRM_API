using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Infrastructure.Configurations;

public class InvoiceTypeConfig : IEntityTypeConfiguration<InvoiceType>
{
    public void Configure(EntityTypeBuilder<InvoiceType> builder)
    {
        // Configuración de la clave primaria
        builder.HasKey(it => it.Id);

        // Propiedades heredadas de BaseEntity
        builder.Property(it => it.CreatedBy).HasMaxLength(256);
        builder.Property(it => it.UpdatedBy).HasMaxLength(256);
        builder.Property(it => it.CreatedAt).IsRequired();
        builder.Property(it => it.UpdatedAt).IsRequired(false);

        // Propiedades específicas de Address
        builder.Property(it => it.Description).HasMaxLength(100).IsRequired();
    }
}
