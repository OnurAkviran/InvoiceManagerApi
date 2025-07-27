using InvoiceManagerApi.DTOs.AuthDtos;
using InvoiceManagerApi.DTOs.BaseDataDtos;
using InvoiceManagerApi.Models.BaseData;

namespace InvoiceManagerApi.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);

        Task<TokenResponseDto?> LoginAsync(LoginDto request);

        Task<TokenResponseDto?> RefreshTokensAsync(RefreshTokenRequestDto request);
    }
}
