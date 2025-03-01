using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace SOLTEC.CRM_API.Infrastructure.Persistence.SeeData;

/// <summary>
/// Inicializador de la base de datos.
/// </summary>
/// <remarks>
/// Constructor del inicializador de base de datos.
/// </remarks>
/// <param name="context">Contexto de la base de datos CRM.</param>
/// <param name="logger">Logger para registrar información.</param>
public class CRMDbInitializer(CRMDbContext context, ILogger<CRMDbInitializer> logger)
{
    private readonly CRMDbContext _context = context;
    private readonly ILogger<CRMDbInitializer> _logger = logger;

    /// <summary>
    /// Inicializa la base de datos aplicando migraciones y poblando datos iniciales si está vacía.
    /// </summary>
    /// <param name="seedData">Indica si se deben insertar datos iniciales.</param>
    public async Task InitializeAsync(bool seedData)
    {
        try
        {
            _logger.LogInformation("Aplicando migraciones...");
            await _context.Database.MigrateAsync();

            if (!seedData) return;

            _logger.LogInformation("Verificando si se necesita inicialización de datos...");
            if (!_context.Customers.Any())
            {
                _logger.LogInformation("Inicializando datos de clientes...");
                _context.Customers.Add(new Domain.Entities.Customer
                {
                    Name = "Cliente Ejemplo",
                    TaxId = "ABC123",
                    IsActive = true,
                    Notes = "Cliente de prueba"
                });
                await _context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error durante la inicialización de la base de datos.");
            throw;
        }
    }
}