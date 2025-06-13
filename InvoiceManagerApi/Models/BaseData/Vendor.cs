namespace InvoiceManagerApi.Models.BaseData
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string VendorCode { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
        public string PhoneNo { get; set; }
        public string CurrencyCode { get; set; }
        public string FaxNo { get; set; }
        public string VatRegistrationNo { get; set; }
        public string RegistrationNo { get; set; }
        public string Gln { get; set; }
        public string PostCode { get; set; }
        public string CountryRegionCode { get; set; }
        public string Email { get; set; }
        public string HomePage { get; set; }
        public int NoOfOrders { get; set; }
        public int NoOfInvoices { get; set; }
        public int CompanyId { get; set; }
        public DateTime SystemCreatedAt { get; set; }
        public DateTime SystemUpdatedAt { get; set; }
    }
}
