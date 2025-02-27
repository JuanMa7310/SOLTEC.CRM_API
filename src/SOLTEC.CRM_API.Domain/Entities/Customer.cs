using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOLTEC.CRM_API.Domain.Entities;

/// <summary>
/// Customer data transfer object
/// </summary>
public class Customer : BaseEntity
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string TaxId { get; set; }
    /// <summary>
    /// Has credit
    /// </summary>
    public bool HasCredit { get; set; }

    /// <summary>
    /// Phone number
    /// </summary>
    public string Notes { get; set; }
    /// <summary>
    /// Is Active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Primary contact id
    /// </summary>
    public int PrimaryContactId { get; set; }
    /// <summary>
    /// Primary contact
    /// </summary>
    [ForeignKey("PrimaryContactId")]
    public Contact PrimaryContact { get; set; }
    /// <summary>
    /// Address id
    /// </summary>
    public int AddressId { get; set; }
    /// <summary>
    /// Address
    /// </summary>
    [ForeignKey("AddressId")]
    public Address Address { get; set; }
    /// <summary>
    /// Credit id
    /// </summary>
    public int? CreditId { get; set; }
    /// <summary>
    /// Credit
    /// </summary>
    [ForeignKey("CreditId")]
    public Credit? Credit { get; set; }

    /// <summary>
    /// Branches
    /// </summary>
    public ICollection<Branch>? Branches { get; set; };
    /// <summary>
    /// Invoices
    /// </summary>
    public ICollection<Invoice>? Invoices { get; set; };
}
