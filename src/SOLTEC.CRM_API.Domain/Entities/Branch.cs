using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

public class Branch : BaseEntity
{
    [Required]
    public string Name { get; set; }

    [ForeignKey("AddressId")]
    public Address Address { get; set; }

    public ICollection<Contact> Contacts { get; set; }
}
