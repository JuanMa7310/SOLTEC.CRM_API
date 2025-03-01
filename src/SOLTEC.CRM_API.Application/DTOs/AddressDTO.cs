namespace SOLTEC.CRM_API.Application.DTOs;

public class AddressDTO : BaseDTO
{
    public string Street { get; set; }
    public int ExternalNumber { get; set; }
    public int? InternalNumber { get; set; }
    public string PostalCode { get; set; }
    public string Neighborhood { get; set; }
    public string City { get; set; }
    public string StateOrProvince { get; set; }
    public string Country { get; set; }
}
