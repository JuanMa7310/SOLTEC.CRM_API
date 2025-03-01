using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Infrastructure.Configurations;

public class InvoiceStatusConfig : IEntityTypeConfiguration<InvoiceStatus>
{
    public void Configure(EntityTypeBuilder<InvoiceStatus> builder)
    {
        // Configuración de la clave primaria
        builder.HasKey(ins => ins.Id);

        // Propiedades heredadas de BaseEntity
        builder.Property(ins => ins.CreatedBy).HasMaxLength(256);
        builder.Property(ins => ins.UpdatedBy).HasMaxLength(256);
        builder.Property(ins => ins.CreatedAt).IsRequired();
        builder.Property(ins => ins.UpdatedAt).IsRequired(false);

        // Propiedades específicas de Address
        builder.Property(ins => ins.Description).HasMaxLength(100).IsRequired();
    }
}
