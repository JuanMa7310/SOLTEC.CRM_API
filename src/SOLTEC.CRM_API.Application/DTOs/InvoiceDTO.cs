namespace SOLTEC.CRM_API.Application.DTOs;

public class InvoiceDTO : BaseDTO
{
    public decimal TotalAmount { get; set; }
    public DateTime CreationDate { get; set; }
    public Guid? CanceledInvoiceId { get; set; }
    public int DetailCount { get; set; }
    public bool IsPaid { get; set; }
    public string Notes { get; set; }
    public string Annotations { get; set; }

    public PaymentTypeDTO PaymentType { get; set; }
    public AccountingExerciseDTO AccountingExercise { get; set; }
    public CustomerDTO Customer { get; set; }
    public InvoiceStatusDTO InvoiceStatus { get; set; }
    public InvoiceTypeDTO InvoiceType { get; set; }
}
