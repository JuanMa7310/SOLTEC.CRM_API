using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOLTEC.CRM_API.Domain.Entities;

/// <summary>
/// Representa un cliente en el sistema.
/// </summary>
public class Customer : BaseEntity
{
    /// <summary>
    /// Nombre del cliente.
    /// </summary>
    [Required, MaxLength(255)]
    public string Name { get; set; }

    /// <summary>
    /// Identificador fiscal del cliente.
    /// </summary>
    [Required, MaxLength(50)]
    public string TaxId { get; set; }
    /// <summary>
    /// Has credit
    /// </summary>
    public bool HasCredit { get; set; }

    /// <summary>
    /// Observaciones sobre el cliente.
    /// </summary>
    [MaxLength(1024)]
    public string Notes { get; set; }

    /// <summary>
    /// Indica si el cliente está activo.
    /// </summary>
    public bool IsActive { get; set; }

    #region Navigation Collections
    /// <summary>
    /// Lista de sucursales asociadas al cliente.
    /// </summary>
    public ICollection<Branch>? Branches { get; set; }

    /// <summary>
    /// Lista de facturas asociadas al cliente.
    /// </summary>
    public ICollection<Invoice>? Invoices { get; set; }
    #endregion

    #region Navigation Foreign Keys
    /// <summary>
    /// Identificador del contacto principal.
    /// </summary>
    [Required]
    public Guid PrimaryContactId { get; set; }

    /// <summary>
    /// Relación con el contacto principal.
    /// </summary>
    [Required]
    [ForeignKey("PrimaryContactId")]
    public virtual Contact PrimaryContact { get; set; }

    /// <summary>
    /// Identificador de la dirección del cliente.
    /// </summary>
    public Guid AddressId { get; set; }

    /// <summary>
    /// Relación con la dirección del cliente.
    /// </summary>
    [Required]
    [ForeignKey("AddressId")]
    public virtual Address Address { get; set; }

    /// <summary>
    /// Identificador del crédito asociado (opcional).
    /// </summary>
    public Guid? CreditId { get; set; }

    /// <summary>
    /// Relación con el crédito del cliente.
    /// </summary>
    [Required]
    [ForeignKey("CreditId")]
    public virtual Credit? Credit { get; set; }
    #endregion
}
