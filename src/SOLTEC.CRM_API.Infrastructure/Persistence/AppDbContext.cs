using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Infrastructure.Persistence;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext(options)
{
    /// <summary>
    /// Customers table
    /// </summary>
    public DbSet<Customer> Customers { get; set; }

    /// <summary>
    /// OnModelCreating method
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Customer>().HasKey(c => c.Id);
        modelBuilder.Entity<Customer>().HasIndex(c => c.Email).IsUnique();

        modelBuilder.Entity<Customer>().Property(c => c.FirstName).IsRequired();
        modelBuilder.Entity<Customer>().Property(c => c.LastName).IsRequired();
        modelBuilder.Entity<Customer>().Property(c => c.Email).IsRequired();
        modelBuilder.Entity<Customer>().Property(c => c.PhoneNumber).IsRequired();
        modelBuilder.Entity<Customer>().Property(c => c.Address).IsRequired();
        modelBuilder.Entity<Customer>().Property(c => c.IsActive).IsRequired();
    }
}
