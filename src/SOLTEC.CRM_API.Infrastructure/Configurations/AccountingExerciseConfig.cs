using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Infrastructure.Configurations;

public class AccountingExerciseConfig : IEntityTypeConfiguration<AccountingExercise>
{
    public void Configure(EntityTypeBuilder<AccountingExercise> builder)
    {
        builder.Property(ae => ae.Year).IsRequired();
    }
}
