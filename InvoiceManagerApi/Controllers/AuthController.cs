#pragma warning disable SA1101 // Prefix local calls with this
using InvoiceManagerApi.DTOs.AuthDtos;
using InvoiceManagerApi.DTOs.BaseDataDtos;
using InvoiceManagerApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceManagerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<ActionResult<UserTestDto>> Register(UserDto request)
        {
            var user = await authService.RegisterAsync(request);

            if (user == null)
            {
                return BadRequest("Username already exists");
            }

            return Ok(UserTestDto.FromEntity(user, user.PasswordHash));
        }

        [HttpPost("login")]
        public async Task<ActionResult<TokenResponseDto>> Login(LoginDto request)
        {
            var response = await authService.LoginAsync(request);
            if(response == null)
            {
                return BadRequest("Invalid username or password");
            }

            return Ok(response);
        }

        [HttpPost("refresh-token")]
        public async Task<ActionResult<TokenResponseDto>> RefreshToken(RefreshTokenRequestDto request)
        {
            var result = await authService.RefreshTokensAsync(request);

            if (result == null || result.AccessToken == null || result.RefreshToken == null)
            {
                return Unauthorized("invalidRefreshToken");
            }

            return result;
        }
    }
}
