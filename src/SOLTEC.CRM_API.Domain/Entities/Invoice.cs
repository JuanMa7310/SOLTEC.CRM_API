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

    [Required]
    public int AccountingPeriod { get; set; }

    public bool IsPaid { get; set; }

    [Required]
    public string Status { get; set; }

    [Required]
    public string InvoiceType { get; set; }

    [Required]
    public int DetailCount { get; set; }

    [MaxLength(1024)]
    public string Notes { get; set; }

    [MaxLength(1024)]
    public string Annotations { get; set; }

    /// <summary>
    /// Customer id
    /// </summary>
    [Required]
    public int CustomerId { get; set; }
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
    public int PaymentTypeId { get; set; }
    /// <summary>
    /// Payment type
    /// </summary>
    [Required]
    [ForeignKey("PaymentTypeId")]
    public PaymentType PaymentType { get; set; }

}