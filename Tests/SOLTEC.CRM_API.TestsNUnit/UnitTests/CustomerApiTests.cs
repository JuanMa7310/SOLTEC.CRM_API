using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using NUnit.Framework;
using SOLTEC.CRM_API.Application.DTOs;
using System.Net;
using System.Net.Http.Json;

namespace SOLTEC.CRM_API.TestsNunit.UnitTests;

[TestFixture]
public class CustomerApiTests
{
    private HttpClient _client;

    [SetUp]
    public void Setup()
    {
        var factory = new WebApplicationFactory<Program>();
        _client = factory.CreateClient();
    }

    [Test]
    public async Task GetCustomers_ReturnsSuccessStatusCode()
    {
        var response = await _client.GetAsync("/api/customers");
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }

    [Test]
    public async Task CreateCustomer_ReturnsCreatedStatusCode()
    {
        var customer = new CustomerDTO { FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" };
        var response = await _client.PostAsJsonAsync("/api/customers", customer);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
    }
}
