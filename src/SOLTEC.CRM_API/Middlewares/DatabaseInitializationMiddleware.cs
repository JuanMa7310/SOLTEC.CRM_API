using SOLTEC.CRM_API.Infrastructure.Persistence.SeeData;

namespace SOLTEC.CRM_API.Middlewares;

/// <summary>
/// Middleware para inicializar la base de datos durante el arranque de la aplicación.
/// </summary>
public class DatabaseInitializationMiddleware(RequestDelegate next)
{
    private readonly RequestDelegate _next = next;

    public async Task InvokeAsync(HttpContext context)
    {
        var configuration = context.RequestServices.GetRequiredService<IConfiguration>();
        var logger = context.RequestServices.GetRequiredService<ILogger<DatabaseInitializationMiddleware>>();
        var dbInitializer = context.RequestServices.GetRequiredService<CRMDbInitializer>();

        bool seedData = configuration.GetValue<bool>("DatabaseConfig:SeedData");

        try
        {
            logger.LogInformation("Verificando la inicialización de la base de datos...");

            await dbInitializer.InitializeAsync(seedData);
            logger.LogInformation("Inicialización de la base de datos completada.");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error al inicializar la base de datos.");
            throw;
        }

        // Llamar al siguiente middleware en la tubería
        await _next(context);
    }
}
