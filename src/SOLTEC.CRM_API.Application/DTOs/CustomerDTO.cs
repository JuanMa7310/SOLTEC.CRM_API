namespace SOLTEC.CRM_API.Application.DTOs;

/// <summary>
/// Customer data transfer object
/// </summary>
public class CustomerDTO : BaseDTO
{
    /// <summary>
    /// Customer first name
    /// </summary>
    public string FirstName { get; set; }
    /// <summary>
    /// Customer last name
    /// </summary>
    public string LastName { get; set; }
    /// <summary>
    /// Customer email
    /// </summary>
    public string Email { get; set; }
    /// <summary>
    /// Customer phone number
    /// </summary>
    public string PhoneNumber { get; set; }
    /// <summary>
    /// Customer address
    /// </summary>
    public string Address { get; set; }
    /// <summary>
    /// Customer city
    /// </summary>
    public bool IsActive { get; set; }
}
