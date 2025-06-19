using System.ComponentModel.DataAnnotations;
using InvoiceManagerApi.Models.Purchase;
using InvoiceManagerApi.Models.Sales;

namespace InvoiceManagerApi.Models.BaseData
{
    public class ItemUnitOfMeasure
    {
        public int ItemUnitOfMeasureId { get; set; }

        public int ItemId { get; set; }

        [Required]
        public string Code { get; set; } = null!;

        public int UnitOfMeasureId { get; set; }

        public int QtyPerUnitOfMeasure { get; set; }

        public int CompanyId { get; set; }

        public DateTime SystemCreatedAt { get; set; }

        public DateTime SystemUpdatedAt { get; set; }

        public Item? Item { get; set; }

        public Company? Company { get; set; }

        public UnitOfMeasure? UnitOfMeasure { get; set; }

        public List<SalesLine> SalesLines { get; set; } = new();

        public List<SalesInvoiceLine> SalesInvoiceLines { get; set; } = new();

        public List<PurchaseLine> PurchaseLines { get; set; } = new();

        public List<PurchaseInvoiceLine> PurchaseInvoiceLines { get; set; } = new();
    }
}
