using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

public class PaymentType : BaseEntity
{
    [Required]
    public string Description { get; set; }
}
