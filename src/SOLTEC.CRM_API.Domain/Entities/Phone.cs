using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

/// <summary>
/// Representa un número de teléfono en el sistema.
/// </summary>
public class Phone : BaseEntity
{
    /// <summary>
    /// Número de teléfono.
    /// </summary>
    [Required]
    public string Number { get; set; }

    /// <summary>
    /// Extensión del teléfono (opcional).
    /// </summary>
    public string Extension { get; set; }

    /// <summary>
    /// Indica si el número de teléfono es un móvil.
    /// </summary>
    public bool IsMobile { get; set; }
}
