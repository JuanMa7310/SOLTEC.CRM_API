using System.ComponentModel.DataAnnotations;

namespace SOLTEC.CRM_API.Application.DTOs;

public class LoginDTO
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
