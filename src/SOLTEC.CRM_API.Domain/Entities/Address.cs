using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

/// <summary>
/// Representa una dirección en el sistema.
/// </summary>
public class Address : BaseEntity
{
    /// <summary>
    /// Nombre de la calle.
    /// </summary>
    [Required, MaxLength(255)]
    public string Street { get; set; }

    /// <summary>
    /// Número exterior de la dirección.
    /// </summary>
    [Required]
    public int ExternalNumber { get; set; }

    /// <summary>
    /// Número interior de la dirección (opcional).
    /// </summary>
    public int? InternalNumber { get; set; }

    /// <summary>
    /// Código postal de la dirección.
    /// </summary>
    [Required, MaxLength(20)]
    public string PostalCode { get; set; }

    /// <summary>
    /// Nombre del barrio o colonia.
    /// </summary>
    [Required, MaxLength(100)]
    public string Neighborhood { get; set; }

    /// <summary>
    /// Ciudad donde se encuentra la dirección.
    /// </summary>
    [Required, MaxLength(100)]
    public string City { get; set; }

    /// <summary>
    /// Estado o provincia de la dirección.
    /// </summary>
    [Required, MaxLength(100)]
    public string StateOrProvince { get; set; }

    /// <summary>
    /// País donde se encuentra la dirección.
    /// </summary>
    [Required, MaxLength(100)]
    public string Country { get; set; }
}
