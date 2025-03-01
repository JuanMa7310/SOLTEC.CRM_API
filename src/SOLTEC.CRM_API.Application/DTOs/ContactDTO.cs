namespace SOLTEC.CRM_API.Application.DTOs;

public class ContactDTO : BaseDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string TaxId { get; set; }
    public string Department { get; set; }
    public PhoneDTO Phone { get; set; }
    public string Email { get; set; }
    public bool IsActive { get; set; }
    public string Notes { get; set; }
}
