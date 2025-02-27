using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

public class Phone : BaseEntity
{
    [Required]
    public string Number { get; set; }

    public string Extension { get; set; }

    public bool IsMobile { get; set; }
}
