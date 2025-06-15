namespace InvoiceManagerApi.Models.BaseData
{
    public class UnitOfMeasure
    {
        public int UnitOfMeasureId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
        public DateTime SystemCreatedAt { get; set; }
        public DateTime SystemUpdatedAt { get; set; }
        public Company Company { get; set; }
    }
}
