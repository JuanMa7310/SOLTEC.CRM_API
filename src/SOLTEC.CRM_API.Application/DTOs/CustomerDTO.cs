namespace SOLTEC.CRM_API.Application.DTOs;

/// <summary>
/// Customer data transfer object
/// </summary>
public class CustomerDTO : BaseDTO
{
    public string Name { get; set; }
    public string TaxId { get; set; }
    public bool IsActive { get; set; }
    public string Notes { get; set; }

    public ContactDTO PrimaryContact { get; set; }
    public AddressDTO Address { get; set; }
    public CreditDTO Credit { get; set; }
    public List<BranchDTO> Branches { get; set; }
    public List<InvoiceDTO> Invoices { get; set; }
}
