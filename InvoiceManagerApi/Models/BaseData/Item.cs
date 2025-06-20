using System.ComponentModel.DataAnnotations;
using InvoiceManagerApi.Models.Purchase;
using InvoiceManagerApi.Models.Sales;

namespace InvoiceManagerApi.Models.BaseData
{
    public class Item
    {
        public int ItemId { get; set; }

        [Required]
        [MaxLength(20)]
        public string ItemCode { get; set; } = null!;

        [MaxLength(100)]
        public string? Description { get; set; }

        public int BaseUnitOfMeasureId { get; set; }

        [MaxLength(10)]
        public string? BaseUnitOfMeasureCode { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? UnitCost { get; set; }

        public decimal? GrossWeightBase { get; set; }

        public decimal? NetWeightBase { get; set; }

        public decimal? QtyOnSalesOrder { get; set; }

        public decimal? QtyOnPurchaseOrder { get; set; }

        public int SalesUnitOfMeasureId { get; set; }

        [MaxLength(10)]
        public string? SalesUnitOfMeasureCode { get; set; }

        public int PurchaseUnitOfMeasureId { get; set; }

        [MaxLength(10)]
        public string? PurchaseUnitOfMeasureCode { get; set; }

        public int CompanyId { get; set; }

        public DateTime SystemCreatedAt { get; set; }

        public DateTime SystemUpdatedAt { get; set; }

        public List<ItemUnitOfMeasure> BaseUnitOfMeasure { get; set; } = new();

        public List<ItemUnitOfMeasure> SalesUnitOfMeasure { get; set; } = new();

        public List<ItemUnitOfMeasure> PurchaseUnitOfMeasure { get; set; } = new();

        public Company? Company { get; set; }

        public List<SalesLine> SalesLines { get; set; } = new();

        public List<PurchaseLine> PurchaseLines { get; set; } = new();

        public List<SalesInvoiceLine> SalesInvoiceLines { get; set; } = new();

        public List<PurchaseInvoiceLine> PurchaseInvoiceLines { get; set; } = new();
    }
}
