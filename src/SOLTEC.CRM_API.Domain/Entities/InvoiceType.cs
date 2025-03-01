using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

/// <summary>
/// Representa un tipo de factura en el sistema.
/// </summary>
public class InvoiceType : BaseEntity
{
    /// <summary>
    /// Descripción del tipo de factura.
    /// </summary>
    [Required]
    public string Description { get; set; }
}
