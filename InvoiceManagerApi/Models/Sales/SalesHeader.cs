using InvoiceManagerApi.Models.BaseData;
using System.ComponentModel.DataAnnotations;

namespace InvoiceManagerApi.Models.Sales
{
    public class SalesHeader
    {
        public int SalesHeaderId { get; set; }

        public int CustomerId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CustomerName { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string CustomerAddress { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string CustomerCity { get; set; } = null!;

        public DateOnly OrderDate { get; set; }

        public DateOnly PostingDate { get; set; }

        [MaxLength(100)]
        public string? PostingDescription { get; set; }

        [Required]
        public string Status { get; set; } = null!;

        [MaxLength(10)]
        public string? CurrencyCode { get; set; }

        public decimal Amount { get; set; }

        public DateOnly DocumentDate { get; set; }

        public int CompanyId { get; set; }

        public DateTime SystemCreatedAt { get; set; }

        public DateTime SystemUpdatedAt { get; set; }

        public Company? Company { get; set; }

        public Customer? Customer { get; set; }

        public List<SalesLine> SalesLines { get; set; } = new();
    }
}
