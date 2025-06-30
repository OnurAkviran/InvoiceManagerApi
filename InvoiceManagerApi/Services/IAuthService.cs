using InvoiceManagerApi.DTOs;
using InvoiceManagerApi.Models.BaseData;

namespace InvoiceManagerApi.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);

        Task<string?> LoginAsync(LoginDto request);
    }
}
