using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

/// <summary>
/// Representa un tipo de pago en el sistema.
/// </summary>
public class PaymentType : BaseEntity
{
    /// <summary>
    /// Descripción del tipo de pago.
    /// </summary>
    [Required]
    public string Description { get; set; }
}
