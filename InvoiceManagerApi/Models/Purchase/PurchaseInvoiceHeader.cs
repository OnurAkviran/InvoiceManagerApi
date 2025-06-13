using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InvoiceManagerApi.Models.Purchase
{
    public class PurchaseInvoiceHeader
    {
        public int PurchaseInvoiceHeaderId { get; set; }
        public int PurchaseHeaderId { get; set; }
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string VendorCity { get; set; }
        public DateOnly OrderDate { get; set; }
        public DateOnly PostingDate { get; set; }
        public string PostingDescription  { get; set; }
        public string Status  { get; set; }
        public string CurrencyCode  { get; set; }
        public decimal Amount  { get; set; }
        public DateOnly DocumentDate  { get; set; }
        public int CompanyId  { get; set; }
        public DateTime SystemCreatedAt  { get; set; }
        public DateTime SystemUpdatedAt { get; set; }
    }
}
