using InvoiceManagerApi.Models.Purchase;
using InvoiceManagerApi.Models.Sales;
using System.Data;

namespace InvoiceManagerApi.Models.BaseData
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string CountryRegionCode { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public string BankName { get; set; }
        public string BankAccountNo { get; set; }
        public string VatRegistrationNo { get; set; }
        public string RegistrationNo { get; set; }
        public string Email { get; set; }
        public string HomePage { get; set; }
        public string IBAN{ get; set; }
        public string Gln { get; set; }
        public DateTime SystemCreatedAt { get; set; }
        public DateTime SystemUpdatedAt { get; set; }
        public List<SalesHeader> SalesHeaders { get; set; }
        public List<PurchaseHeader> PurchaseHeaders { get; set; }
        public List<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; }
        public List<PurchaseInvoiceHeader> PurchaseInvoiceHeaders { get; set; }
        public List<ItemUnitOfMeasure> ItemUnitOfMeasures { get; set; }
        public List<UnitOfMeasure> UnitOfMeasures { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Item> Items { get; set; }
        public List<Vendor> Vendors { get; set; }
        
    }
}
