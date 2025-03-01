using SOLTEC.CRM_API.Domain.Entities;

namespace SOLTEC.CRM_API.Domain.Repositories;

/// <summary>
/// Interfaz de repositorio para la entidad Customer.
/// </summary>
public interface ICustomerRepository : IGenericRepository<Customer>
{
    /// <summary>
    /// Obtiene todos los clientes que están activos.
    /// </summary>
    /// <returns>Lista de clientes activos.</returns>
    Task<IEnumerable<Customer>> GetActiveCustomersAsync();
}
