using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using SOLTEC.CRM_API.Application.DTOs;
using System.Net;
using System.Net.Http.Json;
using Xunit;

namespace SOLTEC.CRM_API.TestsXUnit.IntegrationTests;

public class CustomerApiTests(WebApplicationFactory<Program> factory) : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client = factory.CreateClient();

    [Fact]
    public async Task GetCustomers_ReturnsSuccessStatusCode()
    {
        var response = await _client.GetAsync("/api/customers");
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task CreateCustomer_ReturnsCreatedStatusCode()
    {
        var customer = new CustomerDTO { FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" };
        var response = await _client.PostAsJsonAsync("/api/customers", customer);
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.Created, response.StatusCode);
    }
}
