using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace InvoiceManagerApi.Models.BaseData
{
    public class ItemUnitOfMeasure
    {
        public int ItemUnitOfMeasureId { get; set; }
        public int ItemId { get; set; }
        public string Code { get; set; }
        public int UnitOfMeasureId { get; set; }
        public int QtyPerUnitOfMeasure { get; set; }
        public int CompanyId { get; set; }
        public DateTime SystemCreatedAt { get; set; }
        public DateTime SystemUpdatedAt { get; set; }
    }
}
