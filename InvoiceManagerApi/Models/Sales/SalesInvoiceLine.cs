namespace InvoiceManagerApi.Models.Sales
{
    public class SalesInvoiceLine
    {
        public int SalesInvoiceLineId { get; set; }
        public int SalesInvoiceHeaderId { get; set; }
        public int LineNo { get; set; }
        public int ItemId { get; set; }
        public string Description { get; set; }
        public int UnitOfMeasureId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitCost { get; set; }
        public decimal Amount { get; set; }
        public  DateTime SystemCreatedAt { get; set; }
        public DateTime SystemUpdatedAt { get; set; }
    }
}
