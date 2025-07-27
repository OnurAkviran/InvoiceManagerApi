using System.ComponentModel.DataAnnotations;
using InvoiceManagerApi.Models.BaseData;
using InvoiceManagerApi.Models.Purchase;
using InvoiceManagerApi.Models.Sales;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace InvoiceManagerApi.DTOs.BaseDataDtos
{
    public class CompanyDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [MaxLength(100)]
        public string? DisplayName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string City { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        public string PostCode { get; set; } = null!;

        [Required]
        [MaxLength(10)]
        public string CountryRegionCode { get; set; } = null!;

        [MaxLength(30)]
        public string? PhoneNo { get; set; }

        [MaxLength(30)]
        public string? FaxNo { get; set; }

        [MaxLength(100)]
        public string? BankName { get; set; }

        [MaxLength(30)]
        public string? BankAccountNo { get; set; }

        [MaxLength(20)]
        public string? VatRegistrationNo { get; set; }

        [MaxLength(20)]
        public string? RegistrationNo { get; set; }

        [MaxLength(80)]
        public string? Email { get; set; }

        [MaxLength(80)]
        public string? HomePage { get; set; }

        [MaxLength(50)]
        public string? IBAN { get; set; }

        [MaxLength(13)]
        public string? Gln { get; set; }

        public static CompanyDto FromEntity(Company company)
        {
            return new CompanyDto
            {
                Name = company.Name,
                DisplayName = company.DisplayName,
                Address = company.Address,
                City = company.City,
                PostCode = company.PostCode,
                CountryRegionCode = company.CountryRegionCode,
                PhoneNo = company.PhoneNo,
                FaxNo = company.FaxNo,
                BankName = company.BankName,
                BankAccountNo = company.BankAccountNo,
                VatRegistrationNo = company.VatRegistrationNo,
                RegistrationNo = company.RegistrationNo,
                Email = company.Email,
                HomePage = company.HomePage,
                IBAN = company.IBAN,
                Gln = company.Gln
            };
        }

        public Company ToEntity()
        {
            return new Company
            {
                Name = Name,
                DisplayName = DisplayName,
                Address = Address,
                City = City,
                PostCode = PostCode,
                CountryRegionCode = CountryRegionCode,
                PhoneNo = PhoneNo,
                FaxNo = FaxNo,
                BankName = BankName,
                BankAccountNo = BankAccountNo,
                VatRegistrationNo = VatRegistrationNo,
                RegistrationNo = RegistrationNo,
                Email = Email,
                HomePage = HomePage,
                IBAN = IBAN,
                Gln = Gln,
                SystemCreatedAt = DateTime.UtcNow
            };
        }
    }
}
