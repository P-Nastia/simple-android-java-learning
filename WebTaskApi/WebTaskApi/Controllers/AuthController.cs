using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebTaskApi.Interfaces;
using WebTaskApi.Models.Auth;

namespace WebTaskApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController(IAuthService authService) : ControllerBase
{
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginModel model)
    {
        string result = await authService.LoginAsync(model);
        if (string.IsNullOrEmpty(result))
        {
            return BadRequest(new
            {
                Status = 400,
                IsValid = false,
                Errors = new { Email = "Невірний логін або пароль" }
            });
        }
        return Ok(new
        {
            Token = result
        });
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromForm] RegisterModel model)
    {
        string result = await authService.RegisterAsync(model);
        if (string.IsNullOrEmpty(result))
        {
            return BadRequest(new
            {
                Status = 400,
                IsValid = false,
                Errors = new { Email = "Щось пішло не так" }
            });
        }
        return Ok(new
        {
            Token = result
        });
    }
}

