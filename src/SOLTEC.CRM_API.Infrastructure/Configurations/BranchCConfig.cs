using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Infrastructure.Configurations;

public class BranchConfig : IEntityTypeConfiguration<Branch>
{
    public void Configure(EntityTypeBuilder<Branch> builder)
    {
        // Configuración de la clave primaria
        builder.HasKey(b => b.Id);

        // Propiedades heredadas de BaseEntity
        builder.Property(b => b.CreatedBy).HasMaxLength(256);
        builder.Property(b => b.UpdatedBy).HasMaxLength(256);
        builder.Property(b => b.CreatedAt).IsRequired();
        builder.Property(b => b.UpdatedAt).IsRequired(false);

        // Propiedades específicas de Address
        builder.Property(b => b.Name).HasMaxLength(255).IsRequired();
        builder.HasOne(b => b.Address)
               .WithMany()
               .HasForeignKey(b => b.AddressId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
