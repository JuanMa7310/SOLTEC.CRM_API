using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Application.DTOs;

/// <summary>
/// Base DTO class
/// </summary>
public class BaseDTO
{
    /// <summary>
    /// Clave primaria: Identificador único de la entidad.
    /// </summary>
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Usuario que creó el registro.
    /// </summary>
    [MaxLength(256)]
    public string CreatedBy { get; set; }

    /// <summary>
    /// Fecha y hora de creación del registro.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Usuario que realizó la última actualización del registro.
    /// </summary>
    [MaxLength(256)]
    public string UpdatedBy { get; set; }

    /// <summary>
    /// Fecha y hora de la última actualización del registro.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }
}
