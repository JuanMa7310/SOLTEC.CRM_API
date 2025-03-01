namespace SOLTEC.CRM_API.Application.DTOs;

public class PhoneDTO : BaseDTO
{
    public string Number { get; set; }
    public string Extension { get; set; }
    public bool IsMobile { get; set; }
}
