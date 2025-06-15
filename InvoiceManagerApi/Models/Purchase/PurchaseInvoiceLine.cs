namespace InvoiceManagerApi.Models.Purchase
{
    public class PurchaseInvoiceLine
    {
        public int PurchaseInvoiceLineId { get; set; }
        public int PurchaseInvoiceHeaderId { get; set; }
        public int LineNo { get; set; }
        public int ItemId { get; set; }
        public string Description { get; set; }
        public int UnitOfMeasureId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitCost { get; set; }
        public decimal Amount { get; set; }
        public DateTime SystemCreatedAt { get; set; }
        public DateTime SystemUpdatedAt { get; set; }
        public PurchaseInvoiceHeader PurchaseInvoiceHeader { get; set; }
    }
}
