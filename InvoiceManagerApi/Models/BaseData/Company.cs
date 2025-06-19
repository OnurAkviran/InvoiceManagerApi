using System.ComponentModel.DataAnnotations;
using InvoiceManagerApi.Models.Purchase;
using InvoiceManagerApi.Models.Sales;

namespace InvoiceManagerApi.Models.BaseData
{
    public class Company
    {
        public int CompanyId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public string? DisplayName { get; set; }

        [Required]
        public string Address { get; set; } = null!;

        [Required]
        public string City { get; set; } = null!;

        [Required]
        public string PostCode { get; set; } = null!;

        [Required]
        public string CountryRegionCode { get; set; } = null!;

        public string? PhoneNo { get; set; }

        public string? FaxNo { get; set; }

        public string? BankName { get; set; }

        public string? BankAccountNo { get; set; }

        public string? VatRegistrationNo { get; set; }

        public string? RegistrationNo { get; set; }

        public string? Email { get; set; }

        public string? HomePage { get; set; }

        public string? IBAN { get; set; }

        public string? Gln { get; set; }

        public DateTime SystemCreatedAt { get; set; }

        public DateTime SystemUpdatedAt { get; set; }

        public List<SalesHeader> SalesHeaders { get; set; } = new();

        public List<PurchaseHeader> PurchaseHeaders { get; set; } = new();

        public List<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; } = new();

        public List<PurchaseInvoiceHeader> PurchaseInvoiceHeaders { get; set; } = new();

        public List<ItemUnitOfMeasure> ItemUnitOfMeasures { get; set; } = new();

        public List<UnitOfMeasure> UnitOfMeasures { get; set; } = new();

        public List<Customer> Customers { get; set; } = new();

        public List<Item> Items { get; set; } = new();

        public List<Vendor> Vendors { get; set; } = new();
    }
}
