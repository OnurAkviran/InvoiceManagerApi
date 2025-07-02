using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using InvoiceManagerApi.Data;
using InvoiceManagerApi.DTOs;
using InvoiceManagerApi.Models.BaseData;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace InvoiceManagerApi.Services
{
    public class AuthService(InvoiceManagerContext _db) : IAuthService
    {
        public async Task<User?> RegisterAsync(UserDto request)
        {
            if (await _db.Users.AnyAsync(u => u.UserName == request.UserName))
            {
                return null;
            }

            var user = new User();
            var hashedPassword = new PasswordHasher<User>()
                .HashPassword(user, request.Password);

            user.UserName = request.UserName;
            user.PasswordHash = hashedPassword;
            user.FullName = request.FullName;
            user.Email = request.Email;

            _db.Users.Add(user);
            await _db.SaveChangesAsync();
            return user;
        }

        public async Task<TokenResponseDto?> LoginAsync(LoginDto request)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.UserName == request.UserName);

            bool isUserNull = user == null;
            bool isPasswordVerificationFailed = new PasswordHasher<User>()
                .VerifyHashedPassword(user, user.PasswordHash, request.Password)
                == PasswordVerificationResult.Failed;

            if (isUserNull || isPasswordVerificationFailed)
            {
                return null;
            }

            return await this.CreateTokenResponse(user);
        }

        private async Task<TokenResponseDto> CreateTokenResponse(User? user)
        {
            return new TokenResponseDto
            {
                AccessToken = CreateToken(user),
                RefreshToken = await this.GenerateAndSaveRefreshTokenAsync(user)
            };
        }

        private static string CreateToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Role, user.Role)
            };

            DotNetEnv.Env.Load();
            var tokenKey = Environment.GetEnvironmentVariable("JWT_TOKENKEY");

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(tokenKey!));

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

            var tokenDescriptor = new JwtSecurityToken(
                issuer: Environment.GetEnvironmentVariable("JWT_ISSUER"),
                audience: Environment.GetEnvironmentVariable("JWT_AUDIENCE"),
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }

        private static string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }

        private async Task<string> GenerateAndSaveRefreshTokenAsync(User user)
        {
            var refreshToken = GenerateRefreshToken();
            user.RefreshToken = refreshToken;
            user.RefreshTokenExpireDateTime = DateTime.UtcNow.AddDays(7);
            await _db.SaveChangesAsync();
            return refreshToken;
        }

        private async Task<User?> ValidateRefreshTokenAsync(int userId, string refreshToken)
        {
            var user = await _db.Users.FindAsync(userId);
            if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpireDateTime <= DateTime.UtcNow)
            {
                return null;
            }

            return user;
        }

        public async Task<TokenResponseDto?> RefreshTokensAsync(RefreshTokenRequestDto request)
        {
            var user = await ValidateRefreshTokenAsync(request.UserId, request.RefreshToken);

            if (user == null)
            {
                return null;
            }

            return await CreateTokenResponse(user);
        }
    }
}
