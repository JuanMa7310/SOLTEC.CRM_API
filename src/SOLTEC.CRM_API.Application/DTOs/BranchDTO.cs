namespace SOLTEC.CRM_API.Application.DTOs;

public class BranchDTO : BaseDTO
{
    public string Name { get; set; }
    public AddressDTO Address { get; set; }
    public List<ContactDTO> Contacts { get; set; }
}
