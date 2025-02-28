using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Domain.Entities;

public class AccountingExercise : BaseEntity
{
    [Required]
    public int Year { get; set; }

    [Required]
    public DateOnly StartDate { get; set; }

    [Required]
    public DateOnly EndDate { get; set; }
}
