using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

public class Credit : BaseEntity
{
    [Required]
    public decimal TotalAmount { get; set; }

    [Required]
    public decimal UsedAmount { get; set; }
}
