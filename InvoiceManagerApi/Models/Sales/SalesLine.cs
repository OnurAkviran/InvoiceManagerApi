using InvoiceManagerApi.Models.BaseData;
using System.ComponentModel.DataAnnotations;

namespace InvoiceManagerApi.Models.Sales
{
    public class SalesLine
    {
        public int SalesLineId { get; set; }

        public int SalesHeaderId { get; set; }

        public int LineNo { get; set; }

        public int ItemId { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; }

        public int UnitOfMeasureId { get; set; }

        public decimal Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal UnitCost { get; set; }

        public decimal Amount { get; set; }

        public DateTime SystemCreatedAt { get; set; }

        public DateTime SystemUpdatedAt { get; set; }

        public SalesHeader? SalesHeader { get; set; }

        public Item? Item { get; set; }

        public ItemUnitOfMeasure? ItemUnitOfMeasure { get; set; }
    }
}
