using Moq;
using NUnit.Framework;
using SOLTEC.CRM_API.Application.DTOs;
using SOLTEC.CRM_API.Application.Interfaces;

namespace SOLTEC.CRM_API.TestsNunit.IntegrationTests;

[TestFixture]
public class CustomerServiceTests
{
    private Mock<ICustomerService> _customerServiceMock;

    [SetUp]
    public void Setup()
    {
        _customerServiceMock = new Mock<ICustomerService>();
    }

    [Test]
    public async Task GetAllCustomers_ShouldReturnListOfCustomers()
    {
        // Arrange
        var customers = new List<CustomerDTO>
            {
                new() { Id = 1, FirstName = "John", LastName = "Doe" },
                new() { Id = 2, FirstName = "Jane", LastName = "Smith" }
            };

        _customerServiceMock.Setup(s => s.GetAllAsync()).ReturnsAsync(customers);

        // Act
        var result = await _customerServiceMock.Object.GetAllAsync();

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(result.Count(), Is.EqualTo(2));
    }
}
