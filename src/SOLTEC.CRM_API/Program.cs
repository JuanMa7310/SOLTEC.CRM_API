using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Mvc;
using SOLTEC.CRM_API.Configurations;
using SOLTEC.CRM_API.Extensions;
using SOLTEC.CRM_API.Infrastructure;
using SOLTEC.CRM_API.Infrastructure.Persistence;
using SOLTEC.CRM_API.Infrastructure.Persistence.SeeData;
using SOLTEC.CRM_API.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options => 
{ 
    options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerDocumentation();
builder.Services.AddCorsPolicy();
builder.Services.AddAntiforgery(options =>
{
    options.HeaderName = "X-XSRF-TOKEN";
});

// Protección contra inyección SQL usando consultas parametrizadas en EF Core
builder.Services.AddDatabaseConfiguration(builder.Configuration);
builder.Services.AddAuthenticationConfiguration(builder.Configuration);
// Registrar CRMDbInitializer como servicio
builder.Services.AddScoped<CRMDbInitializer>();

//Protección contra inyección de código en los datos recibidos.
builder.Services.AddMvc(options =>
{ 
    options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
});
builder.Services.AddInfrastructure();


var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();
app.UseMiddleware<JwtMiddleware>();
app.UseCorsPolicy();
app.UseSwaggerDocumentation();
// Usar el Middleware para inicializar la base de datos
app.UseDatabaseInitialization();

app.Use(async (context, next) =>
{
    var antiforgery = context.RequestServices.GetRequiredService<IAntiforgery>();
    var tokens = antiforgery.GetAndStoreTokens(context);
    context.Response.Cookies.Append("XSRF-TOKEN", tokens.RequestToken!, new CookieOptions { HttpOnly = false });
    await next();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
