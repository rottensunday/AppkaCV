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
    [Route("[controller]")]
    public class JobOffersController : ControllerBase
    {
        private DataContext offersRepository;
        public JobOffersController(DataContext repo1)
        {
            offersRepository = repo1;
        }

        [HttpGet]
        public IQueryable<JobOffer> GetOffers(string filter, string category, string position,
            string city, int pageSize = 4, int pageNo = 1)
        {
            IQueryable<JobOffer> result = from s in offersRepository.
                                                JobOffers.Include(x => x.Company)
                                                select s;
            if (!String.IsNullOrEmpty(filter))
            {
                result = result.Where(s => s.JobTitle.Contains(filter) || s.Company.Name.Contains(filter));
            }
            if (!String.IsNullOrEmpty(category))
            {
                result = result.Where(s => s.Category.Contains(category));
            }
            if (!String.IsNullOrEmpty(position))
            {
                result = result.Where(s => s.Position.Contains(position));
            }
            if (!String.IsNullOrEmpty(city))
            {
                result = result.Where(s => s.City.Contains(city));
            }

            return result.Skip((pageNo - 1) * pageSize)
                .Take(pageSize);
        }

        [HttpGet("{id}")]
        public JobOffer GetOffer(int id)
        {
            return offersRepository.JobOffers.Include(x => x.Company).FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult<JobOffer>> PostOffer(JobOffer offer)
        {
            offersRepository.JobOffers.Add(offer);
            await offersRepository.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOffer), new { id = offer.Id }, offer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOffer(int id, JobOffer offer)
        {
            if (id != offer.Id)
            {
                return BadRequest();
            }

            offersRepository.Entry(offer).State = EntityState.Modified;

            try
            {
                await offersRepository.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!offersRepository.JobOffers.Any(c => c.Id == id))
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
        public async Task<ActionResult<JobOffer>> DeleteOffer(int id)
        {
            var offer = await offersRepository.JobOffers.FindAsync(id);
            if (offer == null)
            {
                return NotFound();
            }

            offersRepository.JobOffers.Remove(offer);
            await offersRepository.SaveChangesAsync();

            return offer;
        }
    }
}
