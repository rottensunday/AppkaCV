using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appka_CV_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Appka_CV_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompaniesController : ControllerBase
    {
        private DataContext companiesRepository;
        public CompaniesController(DataContext repo1)
        {
            companiesRepository = repo1;
        }

        [HttpGet]
        public IQueryable<Company> GetCompanies(string filter, int pageSize = 4, int pageNo = 1)
        {
            IQueryable<Company> result = from s in companiesRepository.Companies
                                             select s;
            int id;
            bool parsingSuccess = Int32.TryParse(filter, out id);
            if (!String.IsNullOrEmpty(filter))
            {
                result = result.Where(s => s.Name.Contains(filter) || (parsingSuccess && s.Id == id));
            }

            return result.Skip((pageNo - 1) * pageSize)
                .Take(pageSize);
        }

        [HttpGet("CompaniesCount")]
        public int GetCompaniesCount(string filter)
        {
            IQueryable<Company> result = from s in companiesRepository.Companies
                                         select s;
            int id;
            bool parsingSuccess = Int32.TryParse(filter, out id);
            if (!String.IsNullOrEmpty(filter))
            {
                result = result.Where(s => s.Name.Contains(filter) || (parsingSuccess && s.Id == id));
            }
            return result.Count();
        }

        [HttpGet("{id}")]
        public Company GetCompany(int id)
        {
            return companiesRepository.Companies.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult<Company>> PostCompany(Company company)
        {
            companiesRepository.Companies.Add(company);
            await companiesRepository.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCompany), new { id = company.Id }, company);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, Company company)
        {
            if(id != company.Id)
            {
                return BadRequest();
            }

            companiesRepository.Entry(company).State = EntityState.Modified;

            try
            {
                await companiesRepository.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!companiesRepository.Companies.Any(c => c.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Company>> DeleteCompany(int id)
        {
            var company = await companiesRepository.Companies.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            companiesRepository.Companies.Remove(company);
            await companiesRepository.SaveChangesAsync();

            return company;
        }
    }
}
