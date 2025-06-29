using System.ComponentModel.DataAnnotations;

namespace InvoiceManagerApi.Models.BaseData
{
    public class User
    {
        public int UserId { get; set; }

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

        public int CompanyId { get; set; }

        public DateTime SystemCreatedAt { get; set; }

        public DateTime SystemUpdatedAt { get; set; }

        public Company? Company { get; set; }
    }
}
