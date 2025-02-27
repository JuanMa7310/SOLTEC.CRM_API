using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SOLTEC.CRM_API.Infrastructure.Configurations;

namespace SOLTEC.CRM_API.Infrastructure.Persistence;

public static class DbFactory
{
    public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        var dbConfig = configuration.GetSection("DatabaseConfig").Get<DatabaseConfig>();

        if (dbConfig!.Provider == "MySQL")
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseMySql(dbConfig.ConnectionString, ServerVersion.AutoDetect(dbConfig.ConnectionString)));
        }
        else if (dbConfig.Provider == "SQLServer")
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(dbConfig.ConnectionString, sqlOptions => sqlOptions.EnableRetryOnFailure()));
        }
        else if (dbConfig.Provider == "PostgreSQL")
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(dbConfig.ConnectionString));
        }
    }
}
