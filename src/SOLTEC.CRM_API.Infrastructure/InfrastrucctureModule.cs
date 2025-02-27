using Microsoft.Extensions.DependencyInjection;
using SOLTEC.CRM_API.Application.Interfaces;
using SOLTEC.CRM_API.Application.Services;
using SOLTEC.CRM_API.Domain.Repositories;
using SOLTEC.CRM_API.Infrastructure.Repositories;
using SOLTEC.CRM_API.Infrastructure.Security;

namespace SOLTEC.CRM_API.Infrastructure;

public static class InfrastructureModule
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<ICustomerService, CustomerService>();
        services.AddSingleton<JwtTokenService>();
    }
}
