namespace SOLTEC.CRM_API.Application.DTOs;

public class AccountingExerciseDTO : BaseDTO
{
    public int Year { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
}
