using System.ComponentModel.DataAnnotations;
using InvoiceManagerApi.Models.Purchase;

namespace InvoiceManagerApi.Models.BaseData
{
    public class Vendor
    {
        public int VendorId { get; set; }

        [Required]
        [MaxLength(20)]
        public string VendorCode { get; set; } = null!;

        [MaxLength(100)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string City { get; set; } = null!;

        [MaxLength(100)]
        public string? Contact { get; set; }

        [MaxLength(30)]
        public string? PhoneNo { get; set; }

        [MaxLength(10)]
        public string? CurrencyCode { get; set; }

        [MaxLength(30)]
        public string? FaxNo { get; set; }

        [MaxLength(20)]
        public string? VatRegistrationNo { get; set; }

        [MaxLength(50)]
        public string? RegistrationNo { get; set; }

        [MaxLength(13)]
        public string? Gln { get; set; }

        [Required]
        [MaxLength(20)]
        public string PostCode { get; set; } = null!;

        [Required]
        [MaxLength(10)]
        public string CountryRegionCode { get; set; } = null!;

        [MaxLength(80)]
        public string? Email { get; set; }

        [MaxLength(80)]
        public string? HomePage { get; set; }

        public int NoOfOrders { get; set; }

        public int NoOfInvoices { get; set; }

        public int CompanyId { get; set; }

        public DateTime SystemCreatedAt { get; set; }

        public DateTime SystemUpdatedAt { get; set; }

        public Company? Company { get; set; }

        public List<PurchaseHeader> PurchaseHeaders { get; set; } = new();

        public List<PurchaseInvoiceHeader> PurchaseInvoiceHeaders { get; set; } = new();
    }
}
