using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

/// <summary>
/// Representa un estado de factura en el sistema.
/// </summary>
public class InvoiceStatus : BaseEntity
{
    /// <summary>
    /// Descripción del estado de la factura.
    /// </summary>
    [Required]
    public string Description { get; set; }
}
