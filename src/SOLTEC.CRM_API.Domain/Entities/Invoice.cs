using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

public class Invoice : BaseEntity
{
    [Required]
    public decimal TotalAmount { get; set; }

    [Required]
    public DateTime CreationDate { get; set; }

    public Guid? CanceledInvoiceId { get; set; }

    [Required]
    public int FiscalYear { get; set; }

    public bool IsPaid { get; set; }

    [Required]
    public int DetailCount { get; set; }

    [MaxLength(1024)]
    public string Notes { get; set; }

    [MaxLength(1024)]
    public string Annotations { get; set; }

    #region Navigation Foreign Keys
    /// <summary>
    /// Customer id
    /// </summary>
    [Required]
    public Guid CustomerId { get; set; }
    /// <summary>
    /// Customer
    /// </summary>
    [Required]
    [ForeignKey("CustomerId")]
    public Customer Customer { get; set; }
    /// <summary>
    /// Payment type id
    /// </summary>
    [Required]
    public Guid PaymentTypeId { get; set; }
    /// <summary>
    /// Payment type
    /// </summary>
    [Required]
    [ForeignKey("PaymentTypeId")]
    public PaymentType PaymentType { get; set; }
    /// <summary>
    /// Invoice type id
    /// </summary>
    [Required]
    public Guid InvoiceTypeId { get; set; }
    /// <summary>
    /// Invoice type
    /// </summary>
    [Required]
    [ForeignKey("InvoiceTypeId")]
    public InvoiceType InvoiceType { get; set; }
    /// <summary>
    /// Invoice status id
    /// </summary>
    [Required]
    public Guid InvoiceStatusId { get; set; }
    /// <summary>
    /// Invoice status
    /// </summary>
    [Required]
    [ForeignKey("InvoiceStatusId")]
    public InvoiceStatus Status { get; set; }
    /// <summary>
    /// Accounting exercise id
    /// </summary>
    [Required]
    public Guid AccountingExerciseId { get; set; }
    /// <summary>
    /// Accounting exercise
    /// </summary>
    [Required]
    [ForeignKey("AccountingExerciseId")]
    public AccountingExercise AccountingExerccise { get; set; }
    #endregion Navigation Foreign Keys
}