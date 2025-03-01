using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Infrastructure.Configurations;

public class InvoiceConfig : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.HasKey(i => i.Id);

        builder.Property(i => i.CreatedBy).HasMaxLength(256);
        builder.Property(i => i.UpdatedBy).HasMaxLength(256);
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.UpdatedAt).IsRequired(false);

        builder.Property(i => i.TotalAmount).HasColumnType("decimal(18,2)").IsRequired();
        builder.Property(i => i.Notes).HasMaxLength(1024);
        builder.Property(i => i.Annotations).HasMaxLength(1024);

        builder.HasOne(i => i.Customer)
               .WithMany(c => c.Invoices)
               .HasForeignKey(i => i.CustomerId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.PaymentType)
               .WithMany()
               .HasForeignKey(i => i.PaymentTypeId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.InvoiceType)
               .WithMany()
               .HasForeignKey(i => i.InvoiceTypeId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.InvoiceStatus)
               .WithMany()
               .HasForeignKey(i => i.InvoiceStatusId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
