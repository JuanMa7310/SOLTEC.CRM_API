using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

public class Address : BaseEntity
{
    [Required]
    public string Street { get; set; }

    [Required]
    public int ExternalNumber { get; set; }

    public int? InternalNumber { get; set; }

    [Required]
    public string PostalCode { get; set; }

    [Required]
    public string Neighborhood { get; set; }

    [Required]
    public string City { get; set; }

    [Required]
    public string StateOrProvince { get; set; }

    [Required]
    public string Country { get; set; }
}
