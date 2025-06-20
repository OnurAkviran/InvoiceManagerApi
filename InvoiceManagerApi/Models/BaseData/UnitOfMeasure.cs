using System.ComponentModel.DataAnnotations;

namespace InvoiceManagerApi.Models.BaseData
{
    public class UnitOfMeasure
    {
        public int UnitOfMeasureId { get; set; }

        [Required]
        [MaxLength(10)]
        public string Code { get; set; } = null!;

        [MaxLength(50)]
        public string? Description { get; set; }

        public int CompanyId { get; set; }

        public DateTime SystemCreatedAt { get; set; }

        public DateTime SystemUpdatedAt { get; set; }

        public Company? Company { get; set; }

        public List<ItemUnitOfMeasure> ItemUnitOfMeasures { get; set; } = new();
    }
}
