namespace InvoiceManagerApi.DTOs.AuthDtos
{
    public class TokenResponseDto
    {
        required public string AccessToken { get; set; }

        required public string RefreshToken { get; set; }
    }
}
