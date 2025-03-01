using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

/// <summary>
/// Representa un estado de factura en el sistema.
/// </summary>
public class AccountingExercise : BaseEntity
{
    /// <summary>
    /// Año del ejercicio contable.
    /// </summary>
    [Required]
    public int Year { get; set; }

    /// <summary>
    /// Fecha de inicio del ejercicio contable.
    /// </summary>
    [Required]
    public DateOnly StartDate { get; set; }

    /// <summary>
    /// Fecha de fin del ejercicio contable.
    /// </summary>
    [Required]
    public DateOnly EndDate { get; set; }

    /// <summary>
    /// Identificador de la factura asociada al ejercicio contable (Clave foránea).
    /// </summary>
    public virtual Invoice Invoice { get; set; }

}
