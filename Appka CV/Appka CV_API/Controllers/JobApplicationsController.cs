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
    public class JobApplicationsController : ControllerBase
    {
        private DataContext applicationsRepository;
        public JobApplicationsController(DataContext repo1)
        {
            applicationsRepository = repo1;
        }

        [HttpGet]
        public IQueryable<JobApplication> GetApplications(string filter, string category, string position,
            string city, string firstName, string lastName, int pageSize = 4, int pageNo = 1)
        {
            IQueryable<JobApplication> result = from s in applicationsRepository.
                                                JobApplications.Include(x => x.JobOffer)
                                                select s;
            if (!String.IsNullOrEmpty(filter))
            {
                result = result.Where(s => s.JobOffer.JobTitle.Contains(filter));
            }
            if (!String.IsNullOrEmpty(category))
            {
                result = result.Where(s => s.JobOffer.Category.Contains(category));
            }
            if (!String.IsNullOrEmpty(position))
            {
                result = result.Where(s => s.JobOffer.Position.Contains(position));
            }
            if (!String.IsNullOrEmpty(firstName))
            {
                result = result.Where(s => s.FirstName.Contains(firstName));
            }
            if (!String.IsNullOrEmpty(lastName))
            {
                result = result.Where(s => s.LastName.Contains(lastName));
            }
            if (!String.IsNullOrEmpty(city))
            {
                result = result.Where(s => s.JobOffer.City.Contains(city));
            }

            return result.Skip((pageNo - 1) * pageSize)
                .Take(pageSize);
        }

        [HttpGet("{id}")]
        public JobApplication GetApplication(int id)
        {
            return applicationsRepository.JobApplications.Include(x => x.JobOffer).Include(x => x.JobOffer.Company).FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult<JobApplication>> PostApplication(JobApplication application)
        {
            applicationsRepository.JobApplications.Add(application);
            await applicationsRepository.SaveChangesAsync();

            return CreatedAtAction(nameof(GetApplication), new { id = application.Id }, application);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplication(int id, JobApplication application)
        {
            if (id != application.Id)
            {
                return BadRequest();
            }

            applicationsRepository.Entry(application).State = EntityState.Modified;

            try
            {
                await applicationsRepository.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!applicationsRepository.JobApplications.Any(c => c.Id == id))
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
        public async Task<ActionResult<JobApplication>> DeleteApplication(int id)
        {
            var application = await applicationsRepository.JobApplications.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }

            applicationsRepository.JobApplications.Remove(application);
            await applicationsRepository.SaveChangesAsync();

            return application;
        }
    }
}
