using System.ComponentModel.DataAnnotations;
using InvoiceManagerApi.Models.BaseData;

namespace InvoiceManagerApi.Models.Sales
{
    public class SalesInvoiceHeader
    {
        public int SalesInvoiceHeaderId { get; set; }

        public int SalesHeaderId { get; set; }

        public int CustomerId { get; set; }

        [Required]
        public string CustomerName { get; set; } = null!;

        [Required]
        public string CustomerAddress { get; set; } = null!;

        [Required]
        public string CustomerCity { get; set; } = null!;

        public DateOnly OrderDate { get; set; }

        public DateOnly PostingDate { get; set; }

        public string? PostingDescription { get; set; }

        [Required]
        public string Status { get; set; } = null!;

        public string? CurrencyCode { get; set; }

        public decimal Amount { get; set; }

        public DateOnly DocumentDate { get; set; }

        public int CompanyId { get; set; }

        public DateTime SystemCreatedAt { get; set; }

        public DateTime SystemUpdatedAt { get; set; }

        public Company? Company { get; set; }

        public Customer? Customer { get; set; }

        public SalesHeader? SalesHeader { get; set; }

        public List<SalesInvoiceLine> SalesInvoiceLines { get; set; } = new();
    }
}
