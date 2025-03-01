using SOLTEC.CRM_API.Middlewares;

namespace SOLTEC.CRM_API.Extensions

/// <summary>
/// Extensión para registrar el middleware de inicialización de la base de datos.
/// </summary>
public static class DatabaseInitializationMiddlewareExtensions
{
    public static IApplicationBuilder UseDatabaseInitialization(this IApplicationBuilder app)
    {
        return app.UseMiddleware<DatabaseInitializationMiddleware>();
    }
}
