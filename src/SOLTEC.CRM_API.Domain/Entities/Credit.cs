using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

/// <summary>
/// Representa el crédito asignado a un cliente.
/// </summary>
public class Credit : BaseEntity
{
    /// <summary>
    /// Monto total del crédito otorgado.
    /// </summary>
    [Required]
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Monto del crédito ya utilizado.
    /// </summary>
    [Required]
    public decimal UsedAmount { get; set; }

    /// <summary>
    /// Identificador del cliente (Clave foránea).
    /// </summary>
    public virtual Customer Customer { get; set; }
}
