using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appka_CV_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;
using System.Text.RegularExpressions;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Appka_CV_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobOffersController : ControllerBase
    {
        private DataContext offersRepository;
        private IConfiguration Configuration { get; set; }
        public JobOffersController(DataContext repo1, IConfiguration config)
        {
            offersRepository = repo1;
            Configuration = config;
        }

        [HttpGet]
        public IQueryable<JobOffer> GetOffers(string filter, string category, string position,
            string city, string email, int pageSize = 4, int pageNo = 1)
        {
            IQueryable<JobOffer> result = from s in offersRepository.
                                                JobOffers.Include(x => x.Company)
                                                select s;
            int id;
            bool parsingSuccess = Int32.TryParse(filter, out id);
            if (!String.IsNullOrEmpty(filter))
            {
                result = result.Where(s => s.JobTitle.Contains(filter) || s.Company.Name.Contains(filter) || (parsingSuccess && s.Id == id));
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

            result = result.Skip((pageNo - 1) * pageSize)
                .Take(pageSize);
            foreach(var offer in result)
            {
                if (offersRepository.JobApplications.Include(x => x.JobOffer).Any(x => x.JobOffer.Id == offer.Id && x.User == email))
                {
                    offer.HasApplied = true;
                    offer.ApplicationId = offersRepository.JobApplications.Include(x => x.JobOffer).FirstOrDefault(x => x.JobOffer.Id == offer.Id && x.User == email).Id;
                }
                else offer.HasApplied = false;
            }

            string connectionString = Configuration["AzureStorage"];
            CloudStorageAccount account = CloudStorageAccount.Parse(connectionString);
            CloudBlobClient serviceClient = account.CreateCloudBlobClient();
            var container = serviceClient.GetContainerReference("myblobson");
            foreach (var offer in result)
            {
                if (!string.IsNullOrEmpty(offer.FileName))
                {
                    CloudBlockBlob blob = container.GetBlockBlobReference(offer.FileName);
                    string image;
                    using (var stream = new MemoryStream())
                    {
                        blob.DownloadToStreamAsync(stream).Wait();
                        string input = Convert.ToBase64String(stream.ToArray());
                        image = "data:image/"
                                + Path.GetExtension(offer.FileName).Replace(".", "")
                                + ";base64,"
                                + input;
                    }
                    offer.FileData = image;
                }

            }

            return result;
        }

        [HttpGet("JobOffersCount")]
        public int GetJobOffersCount(string filter, string category, string position,
            string city)
        {
            IQueryable<JobOffer> result = from s in offersRepository.
                                               JobOffers.Include(x => x.Company)
                                          select s;
            int id;
            bool parsingSuccess = Int32.TryParse(filter, out id);
            if (!String.IsNullOrEmpty(filter))
            {
                result = result.Where(s => s.JobTitle.Contains(filter) || s.Company.Name.Contains(filter) || (parsingSuccess && s.Id == id));
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
            return result.Count();
        }

        [HttpGet("{id}")]
        public JobOffer GetOffer(int id)
        {
            JobOffer offer = offersRepository.JobOffers.Include(x => x.Company).FirstOrDefault(x => x.Id == id);
            if (!string.IsNullOrEmpty(offer.FileName))
            {
                string connectionString = Configuration["AzureStorage"];
                CloudStorageAccount account = CloudStorageAccount.Parse(connectionString);
                CloudBlobClient serviceClient = account.CreateCloudBlobClient();
                var container = serviceClient.GetContainerReference("myblobson");
                CloudBlockBlob blob = container.GetBlockBlobReference(offer.FileName);
                string image;
                using (var stream = new MemoryStream())
                {
                    blob.DownloadToStreamAsync(stream).Wait();
                    string input = Convert.ToBase64String(stream.ToArray());
                    image = "data:image/"
                            + Path.GetExtension(offer.FileName).Replace(".", "")
                            + ";base64,"
                            + input;
                }
                offer.FileData = image;
            }

            return offer;
        }

        [HttpPost]
        public async Task<ActionResult<JobOffer>> PostOffer(JobOffer offer)
        {
            if (offer == null) return BadRequest();

            if(!string.IsNullOrEmpty(offer.FileName))
            {
                string connectionString = Configuration["AzureStorage"];

                CloudStorageAccount account = CloudStorageAccount.Parse(connectionString);
                CloudBlobClient serviceClient = account.CreateCloudBlobClient();
                var container = serviceClient.GetContainerReference("myblobson");
                string extension = Path.GetExtension(offer.FileName);
                string name = DateTime.Now.ToString().Replace(" ", "-").Replace("/", "-").Replace(":", "-").Replace(".", "-") + extension;
                CloudBlockBlob blob = container.GetBlockBlobReference(name);
                offer.FileName = name;
                int index = offer.FileData.IndexOf(',');
                string data = offer.FileData.Substring(index + 1);
                data = data.Replace("\\", "\\\\");
                var bytes = Convert.FromBase64String(data);
                using (var stream = new MemoryStream(bytes))
                {
                    blob.UploadFromStreamAsync(stream).Wait();
                }
            }



            offersRepository.Entry(offer.Company).State = EntityState.Unchanged;
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
            offersRepository.Entry(offer.Company).State = EntityState.Modified;
            offersRepository.Entry(offer).State = EntityState.Modified;



            if (!string.IsNullOrEmpty(offer.FileName))
            {
                string connectionString = Configuration["AzureStorage"];

                CloudStorageAccount account = CloudStorageAccount.Parse(connectionString);
                CloudBlobClient serviceClient = account.CreateCloudBlobClient();
                var container = serviceClient.GetContainerReference("myblobson");

                string extension = Path.GetExtension(offer.FileName);
                string name = DateTime.Now.ToString().Replace(" ", "-").Replace("/", "-").Replace(":", "-").Replace(".", "-") + extension;
                CloudBlockBlob blob = container.GetBlockBlobReference(name);
                offer.FileName = name; 
                int index = offer.FileData.IndexOf(',');
                string data = offer.FileData.Substring(index + 1);
                data = data.Replace("\\", "\\\\");
                var bytes = Convert.FromBase64String(data);
                using (var stream = new MemoryStream(bytes))
                {
                    blob.UploadFromStreamAsync(stream).Wait();
                }
            }

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

            offersRepository.Entry(offer.Company).State = EntityState.Unchanged;
            offersRepository.JobOffers.Add(offer);

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
