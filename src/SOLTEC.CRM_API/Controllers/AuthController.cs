using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SOLTEC.CRM_API.Application.DTOs;
using SOLTEC.CRM_API.Infrastructure.Security;
using SOLTEC.CRM_API.Models;

namespace SOLTEC.CRM_API.Controllers;

[Route("api/auth")]
[ApiController]
public class AuthController(JwtTokenService jwtTokenService, IConfiguration configuration) : ControllerBase
{
    private readonly JwtTokenService _jwtTokenService = jwtTokenService;
    private readonly IConfiguration _configuration = configuration;

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginDTO loginDTO)
    {
        var configuredUsername = _configuration["Auth:Username"];
        var configuredPassword = _configuration["Auth:Password"];

        if (loginDTO.Username != configuredUsername || loginDTO.Password != configuredPassword)
        {
            return Unauthorized(new ApiResponse(false, "Invalid credentials"));
        }

        var token = _jwtTokenService.GenerateToken("1", loginDTO.Username);
        return Ok(new ApiResponse(true, "Login successful", new { Token = token }));
    }
}
