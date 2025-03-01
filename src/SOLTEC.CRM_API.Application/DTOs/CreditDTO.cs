namespace SOLTEC.CRM_API.Application.DTOs;

public class CreditDTO : BaseDTO
{
    public decimal TotalAmount { get; set; }
    public decimal UsedAmount { get; set; }
}
