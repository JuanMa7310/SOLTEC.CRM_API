using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Infrastructure.Persistence;

public class CRMDbContext(DbContextOptions<CRMDbContext> options) : IdentityDbContext(options)
{
    /// <summary>
    /// Customers table
    /// </summary>
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Phone> Phones { get; set; }
    public DbSet<Credit> Credits { get; set; }
    public DbSet<AccountingExercise> AccountingExercises { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<InvoiceStatus> InvoiceStatuses { get; set; }
    public DbSet<InvoiceType> InvoiceTypes { get; set; }
    public DbSet<PaymentType> PaymentTypes { get; set; }

    /// <summary>
    /// OnModelCreating method
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CRMDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
