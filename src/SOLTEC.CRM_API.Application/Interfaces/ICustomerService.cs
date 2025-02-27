using SOLTEC.CRM_API.Application.DTOs;

namespace SOLTEC.CRM_API.Application.Interfaces;

public interface ICustomerService : IGenericService<CustomerDTO>
{
    Task<IEnumerable<CustomerDTO>> GetActiveCustomersAsync();
}
