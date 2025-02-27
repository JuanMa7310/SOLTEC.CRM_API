using Microsoft.OpenApi.Models;

namespace SOLTEC.CRM_API.Configurations;

public static class SwaggerConfig
{
    public static void AddSwaggerDocumentation(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "CRM API",
                Version = "v1",
                Description = "API para la gestión de clientes en un CRM"
            });
        });
    }

    public static void UseSwaggerDocumentation(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "CRM API v1");
            c.RoutePrefix = string.Empty;
        });
    }
}
