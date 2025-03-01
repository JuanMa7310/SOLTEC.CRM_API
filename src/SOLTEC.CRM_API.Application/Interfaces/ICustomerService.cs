using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Application.Interfaces;

/// <summary>
/// Interfaz de servicio para la entidad Customer.
/// </summary>
public interface ICustomerService : IGenericService<Customer>
{
    /// <summary>
    /// Obtiene todos los clientes que están activos.
    /// </summary>
    /// <returns>Lista de clientes activos.</returns>
    Task<IEnumerable<Customer>> GetActiveCustomersAsync();
}
