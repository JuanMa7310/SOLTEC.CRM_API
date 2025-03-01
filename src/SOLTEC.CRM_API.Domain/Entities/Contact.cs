using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOLTEC.CRM_API.Domain.Entities;

/// <summary>
/// Representa un contacto en el sistema.
/// </summary>
public class Contact : BaseEntity
{
    /// <summary>
    /// Nombre del contacto.
    /// </summary>
    [Required, MaxLength(100)]
    public string FirstName { get; set; }

    /// <summary>
    /// Apellidos del contacto.
    /// </summary>
    [Required, MaxLength(100)]
    public string LastName { get; set; }

    /// <summary>
    /// Identificador fiscal del contacto.
    /// </summary>
    [Required, MaxLength(50)]
    public string TaxId { get; set; }

    /// <summary>
    /// Departamento al que pertenece el contacto.
    /// </summary>
    public string Department { get; set; }

    /// <summary>
    /// Correo electrónico del contacto.
    /// </summary>
    [EmailAddress, MaxLength(255)]
    public string Email { get; set; }

    /// <summary>
    /// Indica si el contacto está activo.
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Observaciones sobre el contacto.
    /// </summary>
    [MaxLength(1024)]
    public string Notes { get; set; }

    #region Navigation Foreign Keys
    /// <summary>
    /// Clave foránea: Identificador del teléfono asociado.
    /// </summary>
    [Required]
    public Guid PhoneId { get; set; }
    /// <summary>
    /// Relación con el teléfono del contacto.
    /// </summary>
    [Required]
    [ForeignKey("PhoneId")]
    public virtual Phone Phone { get; set; }
    #endregion

    /// <summary>
    /// Identificador de la dirección asociada al cliente (Clave foránea).
    /// </summary>
    public virtual Customer Customer { get; set; }
    /// <summary>
    /// Identificador de la dirección asociada a la sucursal (Clave foránea).
    /// </summary>
    public virtual Branch Branch { get; set; }
}
