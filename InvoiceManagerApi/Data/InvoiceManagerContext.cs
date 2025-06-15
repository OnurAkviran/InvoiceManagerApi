using InvoiceManagerApi.Models.BaseData;
using InvoiceManagerApi.Models.Purchase;
using InvoiceManagerApi.Models.Sales;
using Microsoft.EntityFrameworkCore;

namespace InvoiceManagerApi.Data
{
    public class InvoiceManagerContext : DbContext
    {
        public InvoiceManagerContext(DbContextOptions<InvoiceManagerContext> options) : base(options) { }
        #region base data
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemUnitOfMeasure> ItemsUnitOfMeasures { get; set; }
        public DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        #endregion
        #region purchase
        public DbSet<PurchaseHeader> PurchaseHeaders { get; set; }
        public DbSet<PurchaseLine> PurchaseLines { get; set; }
        public DbSet<PurchaseInvoiceHeader> PurchaseInvoiceHeaders { get; set; }
        public DbSet<PurchaseInvoiceLine> PurchaseInvoiceLines { get; set; }
        #endregion
        #region sales
        public DbSet<SalesHeader> SalesHeaders { get; set; }
        public DbSet<SalesLine> SalesLines { get; set; }
        public DbSet<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; }
        public DbSet<SalesInvoiceLine> SalesInvoiceLines { get; set; }
        #endregion
    }
}
