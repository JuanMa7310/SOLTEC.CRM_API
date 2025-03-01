using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Infrastructure.Configurations;

public class AccountingExerciseConfig : IEntityTypeConfiguration<AccountingExercise>
{
    public void Configure(EntityTypeBuilder<AccountingExercise> builder)
    {
        // Configuración de la clave primaria
        builder.HasKey(ae => ae.Id);

        // Propiedades heredadas de BaseEntity
        builder.Property(ae => ae.CreatedBy).HasMaxLength(256);
        builder.Property(ae => ae.UpdatedBy).HasMaxLength(256);
        builder.Property(ae => ae.CreatedAt).IsRequired();
        builder.Property(ae => ae.UpdatedAt).IsRequired(false);

        // Propiedades específicas de Address
        builder.Property(ae => ae.Year).IsRequired();
        builder.Property(ae => ae.StartDate).IsRequired();
        builder.Property(ae => ae.EndDate).IsRequired();
    }
}
