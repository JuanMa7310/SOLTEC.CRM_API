using SOLTEC.CRM_API.Application.DTOs;
using SOLTEC.CRM_API.Application.Interfaces;
using SOLTEC.CRM_API.Domain.Entities;
using SOLTEC.CRM_API.Domain.Repositories;

namespace SOLTEC.CRM_API.Application.Services;

public class CustomerService(ICustomerRepository customerRepository) : GenericService<CustomerDTO, Customer>(customerRepository), ICustomerService
{
    private readonly ICustomerRepository _customerRepository = customerRepository;

    public async Task<IEnumerable<CustomerDTO>> GetActiveCustomersAsync()
    {
        var customers = await _customerRepository.GetActiveCustomersAsync();
        return customers.Select(c => MapToDto(c));
    }

    protected override CustomerDTO MapToDto(Customer entity)
    {
        return new CustomerDTO
        {
            Id = entity.Id,
            Name = entity.Name,
            TaxId = entity.TaxId,
            HasCredit = entity.HasCredit,
            Notes = entity.Notes,
            IsActive = entity.IsActive
        };
    }

    protected override Customer MapToEntity(CustomerDTO dto)
    {
        return new Customer
        {
            Id = dto.Id,
            Name = dto.Name,
            TaxId = dto.TaxId,
            HasCredit = dto.HasCredit,
            Notes = dto.Notes,
            IsActive = dto.IsActive
        };
    }
}
