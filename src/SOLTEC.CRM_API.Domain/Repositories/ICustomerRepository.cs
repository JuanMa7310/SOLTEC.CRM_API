using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Domain.Repositories;

public interface ICustomerRepository : IGenericRepository<Customer>
{
    Task<IEnumerable<Customer>> GetActiveCustomersAsync();
}