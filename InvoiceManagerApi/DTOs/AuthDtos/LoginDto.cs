﻿using System.ComponentModel.DataAnnotations;

namespace InvoiceManagerApi.DTOs.AuthDtos
{
    public class LoginDto
    {
        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;
    }
}
