using InvoiceManagerApi.Models.BaseData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace InvoiceManagerApi.DTOs.BaseDataDtos
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTestDto : ControllerBase
    {
        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        public string PasswordHash { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = null!;

        [Required]
        [MaxLength(80)]
        public string Email { get; set; } = null!;

        public DateTime SystemCreatedAt { get; set; }

        public static UserTestDto FromEntity(User request, string passwordHash)
        {
            return new UserTestDto
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
