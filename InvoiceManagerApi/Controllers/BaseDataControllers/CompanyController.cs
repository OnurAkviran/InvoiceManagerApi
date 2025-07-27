#pragma warning disable SA1101 // Prefix local calls with this
using InvoiceManagerApi.Data;
using InvoiceManagerApi.DTOs.BaseDataDtos;
using InvoiceManagerApi.Models.BaseData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvoiceManagerApi.Controllers.BaseDataControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly InvoiceManagerContext _db;

        public CompanyController(InvoiceManagerContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyDto>>> GetCompanies()
        {
            var companies = await _db.Companies
                .AsNoTracking()
                .ToListAsync();

            var dtos = companies.Select(CompanyDto.FromEntity);
            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyDto>> GetCompany(int id)
        {
            var company = await _db.Companies
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.CompanyId == id);

            if (company == null)
            {
                return NotFound();
            }

            var response = CompanyDto.FromEntity(company);

            return Ok(response);
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<CompanyDto>> PostCompany(CompanyDto companyDto)
        {
            var company = companyDto.ToEntity();

            _db.Companies.Add(company);
            await _db.SaveChangesAsync();

            var responseDto = CompanyDto.FromEntity(company);

            return CreatedAtAction(nameof(GetCompany), new { id = company.CompanyId }, responseDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCompany(int id)
        {
            var company = await _db.Companies.FindAsync(id);

            if (company == null)
            {
                return NotFound();
            }

            _db.Companies.Remove(company);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
