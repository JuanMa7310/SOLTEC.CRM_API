using Microsoft.EntityFrameworkCore;
using SOLTEC.CRM_API.Domain.Entities;
using SOLTEC.CRM_API.Domain.Repositories;
using SOLTEC.CRM_API.Infrastructure.Persistence;

namespace SOLTEC.CRM_API.Infrastructure.Repositories;

public class CustomerRepository(AppDbContext context) : GenericRepository<Customer>(context), ICustomerRepository
{
    public async Task<IEnumerable<Customer>> GetActiveCustomersAsync()
    {
        return await _context.Customers.Where(c => c.IsActive).ToListAsync();
    }
}
