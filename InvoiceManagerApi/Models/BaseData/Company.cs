using System.ComponentModel.DataAnnotations;
using InvoiceManagerApi.Models.Purchase;
using InvoiceManagerApi.Models.Sales;

namespace InvoiceManagerApi.Models.BaseData
{
    public class Company
    {
        public int CompanyId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [MaxLength(100)]
        public string? DisplayName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string City { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        public string PostCode { get; set; } = null!;

        [Required]
        [MaxLength(10)]
        public string CountryRegionCode { get; set; } = null!;

        [MaxLength(30)]
        public string? PhoneNo { get; set; }

        [MaxLength(30)]
        public string? FaxNo { get; set; }

        [MaxLength(100)]
        public string? BankName { get; set; }

        [MaxLength(30)]
        public string? BankAccountNo { get; set; }

        [MaxLength(20)]
        public string? VatRegistrationNo { get; set; }

        [MaxLength(20)]
        public string? RegistrationNo { get; set; }

        [MaxLength(80)]
        public string? Email { get; set; }

        [MaxLength(80)]
        public string? HomePage { get; set; }

        [MaxLength(50)]
        public string? IBAN { get; set; }

        [MaxLength(13)]
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

        public List<User> Users { get; set; } = new();
    }
}
