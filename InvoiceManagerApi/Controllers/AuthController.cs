#pragma warning disable SA1101 // Prefix local calls with this
using InvoiceManagerApi.DTOs;
using InvoiceManagerApi.Models.BaseData;
using InvoiceManagerApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

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
        public async Task<ActionResult<string>> Login(LoginDto request)
        {
            var token = await authService.LoginAsync(request);
            if(token == null)
            {
                return BadRequest("Invalid username or password");
            }

            return Ok(token);
        }
    }
}
