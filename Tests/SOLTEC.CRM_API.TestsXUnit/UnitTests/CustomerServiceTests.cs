using Moq;
using SOLTEC.CRM_API.Application.DTOs;
using SOLTEC.CRM_API.Application.Interfaces;
using Xunit;

namespace SOLTEC.CRM_API.TestsNunit.UnitTests;

public class CustomerServiceTests
{
    private readonly Mock<ICustomerService> _customerServiceMock;

    public CustomerServiceTests()
    {
        _customerServiceMock = new Mock<ICustomerService>();
    }

    [Fact]
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
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
    }
}
