using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Infrastructure.Configurations;

public class BranchConfig : IEntityTypeConfiguration<Branch>
{
    public void Configure(EntityTypeBuilder<Branch> builder)
    {
        builder.Property(b => b.Name).HasMaxLength(255).IsRequired();
        builder.HasOne(b => b.Address)
               .WithMany()
               .HasForeignKey(b => b.AddressId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
