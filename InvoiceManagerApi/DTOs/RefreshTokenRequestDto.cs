namespace InvoiceManagerApi.DTOs
{
    public class RefreshTokenRequestDto
    {
        public int UserId { get; set; }

        required public string RefreshToken { get; set; }
    }
}
