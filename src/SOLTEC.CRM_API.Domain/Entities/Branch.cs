using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

/// <summary>
/// Representa una sucursal de un cliente en el sistema.
/// </summary>
public class Branch : BaseEntity
{
    /// <summary>
    /// Nombre de la sucursal.
    /// </summary>
    [Required]
    public string Name { get; set; }

    #region Navigation Collections
    /// <summary>
    /// Lista de contactos asociados a la sucursal.
    /// </summary>
    public virtual IEnumerable<Contact> Contacts { get; set; }
    #endregion

    #region Navigation Foreign Keys
    /// <summary>
    /// Clave foránea: Identificador de la dirección de la sucursal.
    /// </summary>
    [Required]
    public Guid AddressId { get; set; }
    /// <summary>
    /// Relación con la dirección de la sucursal.
    /// </summary>
    [Required]
    [ForeignKey("AddressId")]
    public virtual Address Address { get; set; }
    /// <summary>
    /// Identificador de la dirección de la sucursal (Clave foránea).
    /// </summary>
    public Guid CustomerId { get; set; }
    [ForeignKey("CustomerId")]
    public virtual Customer Customer { get; set; }
    #endregion
}
