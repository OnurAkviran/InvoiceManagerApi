using System.ComponentModel.DataAnnotations;
using InvoiceManagerApi.Models.Sales;

namespace InvoiceManagerApi.Models.BaseData
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        public string CustomerCode { get; set; } = null!;

        public string? Name { get; set; }

        [Required]
        public string Address { get; set; } = null!;

        [Required]
        public string City { get; set; } = null!;

        public string? Contact { get; set; }

        public string? PhoneNo { get; set; }

        public string? CurrencyCode { get; set; }

        public string? FaxNo { get; set; }

        public string? VatRegistrationNo { get; set; }

        public string? RegistrationNo { get; set; }

        public string? Gln { get; set; }

        [Required]
        public string PostCode { get; set; } = null!;

        [Required]
        public string CountryRegionCode { get; set; } = null!;

        public string? Email { get; set; }

        public string? HomePage { get; set; }

        public int? NoOfOrders { get; set; }

        public int? NoOfInvoices { get; set; }

        public int CompanyId { get; set; }

        public DateTime SystemCreatedAt { get; set; }

        public DateTime SystemUpdatedAt { get; set; }

        public Company? Company { get; set; }

        public List<SalesHeader> SalesHeaders { get; set; } = new();

        public List<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; } = new();
    }
}
