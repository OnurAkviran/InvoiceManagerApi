using InvoiceManagerApi.Models.BaseData;
using System.ComponentModel.DataAnnotations;

namespace InvoiceManagerApi.DTOs.BaseDataDtos
{
    public class UserDto
    {
        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = null!;

        [Required]
        [MaxLength(80)]
        public string Email { get; set; } = null!;

        public static User ToEntity(UserDto request, string passwordHash)
        {
            return new User
            {
                UserName = request.UserName,
                FullName = request.FullName,
                Email = request.Email,
                PasswordHash = passwordHash,
                SystemCreatedAt = DateTime.UtcNow
            };
        }
    }
}
