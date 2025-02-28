using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOLTEC.CRM_API.Domain.Entities;

public class Contact : BaseEntity
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string TaxId { get; set; }

    public string Department { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    public string Notes { get; set; }

    public bool IsActive { get; set; }

    #region Navigation Foreign Keys
    public Guid PhoneId { get; set; }
    [ForeignKey("PhoneId")]
    public Phone Phone { get; set; }
    #endregion
}
