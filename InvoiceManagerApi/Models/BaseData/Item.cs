namespace InvoiceManagerApi.Models.BaseData
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public int BaseUnitOfMeasureId { get; set; }
        public string BaseUnitOfMeasureCode { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitCost { get; set; }
        public decimal GrossWeightBase { get; set; }
        public decimal NetWeightBase{ get; set; }
        public decimal QtyOnSalesOrder { get; set; }
        public decimal QtyOnPurchaseOrder { get; set; }
        public int SalesUnitOfMeasureId { get; set; }
        public string SalesUnitOfMeasureCode { get; set; }
        public int PurchaseUnitOfMeasureId { get; set; }
        public string PurchaseUnitOfMeasureCode { get; set; }
        public int CompanyId { get; set; }
        public DateTime SystemCreatedAt { get; set; }
        public DateTime SystemUpdatedAt { get; set; }
        public List<ItemUnitOfMeasure> BaseUnitOfMeasure { get; set; }
        public Company Company { get; set; }
    }
}
