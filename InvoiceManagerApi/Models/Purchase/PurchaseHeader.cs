using System.ComponentModel.DataAnnotations;
using InvoiceManagerApi.Models.BaseData;

namespace InvoiceManagerApi.Models.Purchase
{
    public class PurchaseHeader
    {
        public int PurchaseHeaderId { get; set; }

        public int VendorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string VendorName { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string VendorAddress { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string VendorCity { get; set; } = null!;

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

        public Vendor? Vendor { get; set; }

        public List<PurchaseLine> PurchaseLines { get; set; } = new();
    }
}
