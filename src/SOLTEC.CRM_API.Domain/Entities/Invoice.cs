using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

/// <summary>
/// Representa una factura en el sistema.
/// </summary>
public class Invoice : BaseEntity
{
    /// <summary>
    /// Monto total de la factura.
    /// </summary>
    [Required]
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Fecha de creación de la factura.
    /// </summary>
    [Required]
    public DateTime CreationDate { get; set; }

    /// <summary>
    /// Clave foránea: Identificador de la factura anulada (opcional).
    /// </summary>
    public Guid? CanceledInvoiceId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [Required]
    public int FiscalYear { get; set; }

    /// <summary>
    /// Indica si la factura ha sido pagada.
    /// </summary>
    public bool IsPaid { get; set; }

    /// <summary>
    /// Número de detalles incluidos en la factura.
    /// </summary>
    [Required]
    public int DetailCount { get; set; }

    /// <summary>
    /// Observaciones sobre la factura.
    /// </summary>
    [MaxLength(1024)]
    public string Notes { get; set; }

    /// <summary>
    /// Anotaciones adicionales sobre la factura.
    /// </summary>
    [MaxLength(1024)]
    public string Annotations { get; set; }

    #region Navigation Foreign Keys
    /// <summary>
    /// Clave foránea: Identificador del cliente asociado.
    /// </summary>
    [Required]
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Relación con el cliente.
    /// </summary>
    [Required]
    [ForeignKey("CustomerId")]
    public Customer Customer { get; set; }

    /// <summary>
    /// Clave foránea: Identificador del tipo de pago.
    /// </summary>
    [Required]
    public Guid PaymentTypeId { get; set; }

    /// <summary>
    /// Relación con el Identificador del tipo de pago.
    /// </summary>
    [Required]
    [ForeignKey("PaymentTypeId")]
    public PaymentType PaymentType { get; set; }

    /// <summary>
    /// Clave foránea: Identificador del tipo de factura.
    /// </summary>
    [Required]
    public Guid InvoiceTypeId { get; set; }

    /// <summary>
    /// Relación con el Identificador del tipo de factura.
    /// </summary>
    [Required]
    [ForeignKey("InvoiceTypeId")]
    public InvoiceType InvoiceType { get; set; }

    /// <summary>
    /// Clave foránea: Identificador del estado de la factura.
    /// </summary>
    [Required]
    public Guid InvoiceStatusId { get; set; }

    /// <summary>
    /// Relación con el Identificador del estado de factura.
    /// </summary>
    [Required]
    [ForeignKey("InvoiceStatusId")]
    public InvoiceStatus Status { get; set; }

    /// <summary>
    /// Clave foránea: Identificador del ejercicio contable.
    /// </summary>
    [Required]
    public Guid AccountingExerciseId { get; set; }

    /// <summary>
    /// Relación con el Identificador del ejercicio contable.
    /// </summary>
    [Required]
    [ForeignKey("AccountingExerciseId")]
    public AccountingExercise AccountingExerccise { get; set; }
    #endregion Navigation Foreign Keys
}