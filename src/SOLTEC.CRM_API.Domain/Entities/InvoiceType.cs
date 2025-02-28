using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

public class InvoiceType : BaseEntity
{
    [Required]
    public string Description { get; set; }
}
