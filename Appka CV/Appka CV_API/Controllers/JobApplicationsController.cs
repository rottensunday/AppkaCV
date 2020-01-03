using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appka_CV_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.IO;

namespace Appka_CV_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobApplicationsController : ControllerBase
    {
        private DataContext applicationsRepository;
        public JobApplicationsController(DataContext repo1)
        {
            applicationsRepository = repo1;
        }

        [HttpGet]
        public IQueryable<JobApplication> GetApplications(string filter, string category, string position,
            string city, string firstName, string lastName, string email, string userType, int pageSize = 4, int pageNo = 1)
        {
            IQueryable<JobApplication> result = from s in applicationsRepository.
                                                JobApplications.Include(x => x.JobOffer)
                                                select s;
            int id;
            bool parsingSuccess = Int32.TryParse(filter, out id);
            if (!String.IsNullOrEmpty(filter))
            {
                result = result.Where(s => s.JobOffer.JobTitle.Contains(filter) || (parsingSuccess && s.Id == id));
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

            if(userType == "User")
            {
                result = result.Where(x => x.User == email);
            }
            else if(userType == "HR")
            {
                result = result.Where(x => x.JobOffer.HR == email);
            }

            string connectionString = "DefaultEndpointsProtocol=https;AccountName=appkacvstorage;AccountKey=1F5gXDzX5zatwbVzvCisref6iHMqZlHl40txPt/O6Z+Lp0qXJ23/aulzauz3TCQEcLCHkxuXLyWRCSPaTHh4Jg==;EndpointSuffix=core.windows.net";
            CloudStorageAccount account = CloudStorageAccount.Parse(connectionString);
            CloudBlobClient serviceClient = account.CreateCloudBlobClient();
            var container = serviceClient.GetContainerReference("myblobson");
            foreach (var application in result)
            {
                if (!string.IsNullOrEmpty(application.FileName))
                {
                    CloudBlockBlob blob = container.GetBlockBlobReference(application.FileName);
                    string file;
                    using (var stream = new MemoryStream())
                    {
                        blob.DownloadToStreamAsync(stream).Wait();
                        string input = Convert.ToBase64String(stream.ToArray());
                        file = "data:application/pdf"
                                + ";base64,"
                                + input;
                    }
                    application.FileData = file;
                }
            }

            return result.Skip((pageNo - 1) * pageSize)
                .Take(pageSize);
        }

        [HttpGet("JobApplicationsCount")]
        public int GetJobApplicationsCount(string filter, string category, string position,
            string city, string firstName, string userType, string email, string lastName)
        {
            IQueryable<JobApplication> result = from s in applicationsRepository.
                                    JobApplications.Include(x => x.JobOffer)
                                                select s;
            int id;
            bool parsingSuccess = Int32.TryParse(filter, out id);
            if (!String.IsNullOrEmpty(filter))
            {
                result = result.Where(s => s.JobOffer.JobTitle.Contains(filter) || (parsingSuccess && s.Id == id));
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

            if (userType == "User")
            {
                result = result.Where(x => x.User == email);
            }
            else if (userType == "HR")
            {
                result = result.Where(x => x.JobOffer.HR == email);
            }

            return result.Count();
        }

        [HttpGet("{id}")]
        public JobApplication GetApplication(int id)
        {
            JobApplication application = applicationsRepository.JobApplications.Include(x => x.JobOffer).Include(x => x.JobOffer.Company).FirstOrDefault(x => x.Id == id);
            if (!string.IsNullOrEmpty(application.FileName))
            {
                string connectionString = "DefaultEndpointsProtocol=https;AccountName=appkacvstorage;AccountKey=1F5gXDzX5zatwbVzvCisref6iHMqZlHl40txPt/O6Z+Lp0qXJ23/aulzauz3TCQEcLCHkxuXLyWRCSPaTHh4Jg==;EndpointSuffix=core.windows.net";
                CloudStorageAccount account = CloudStorageAccount.Parse(connectionString);
                CloudBlobClient serviceClient = account.CreateCloudBlobClient();
                var container = serviceClient.GetContainerReference("myblobson");
                CloudBlockBlob blob = container.GetBlockBlobReference(application.FileName);
                string image;
                using (var stream = new MemoryStream())
                {
                    blob.DownloadToStreamAsync(stream).Wait();
                    string input = Convert.ToBase64String(stream.ToArray());
                    image = "data:application/pdf"
                            + ";base64,"
                            + input;
                }
                application.FileData = image;
            }
            return application;
        }

        [HttpPost]
        public async Task<ActionResult<JobApplication>> PostApplication(JobApplication application)
        {
            if (!string.IsNullOrEmpty(application.FileName))
            {
                string connectionString = "DefaultEndpointsProtocol=https;AccountName=appkacvstorage;AccountKey=1F5gXDzX5zatwbVzvCisref6iHMqZlHl40txPt/O6Z+Lp0qXJ23/aulzauz3TCQEcLCHkxuXLyWRCSPaTHh4Jg==;EndpointSuffix=core.windows.net";

                CloudStorageAccount account = CloudStorageAccount.Parse(connectionString);
                CloudBlobClient serviceClient = account.CreateCloudBlobClient();
                var container = serviceClient.GetContainerReference("myblobson");
                string extension = Path.GetExtension(application.FileName);
                string name = DateTime.Now.ToString().Replace(" ", "-").Replace("/", "-").Replace(":", "-").Replace(".", "-") + extension;
                CloudBlockBlob blob = container.GetBlockBlobReference(name);
                application.FileName = name;
                int index = application.FileData.IndexOf(',');
                string data = application.FileData.Substring(index + 1);
                data = data.Replace("\\", "\\\\");
                var bytes = Convert.FromBase64String(data);
                using (var stream = new MemoryStream(bytes))
                {
                    blob.UploadFromStreamAsync(stream).Wait();
                }
            }

            applicationsRepository.Entry(application.JobOffer).State = EntityState.Unchanged;
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

            applicationsRepository.Entry(application.JobOffer).State = EntityState.Unchanged;
            applicationsRepository.Entry(application).State = EntityState.Modified;

            if (!string.IsNullOrEmpty(application.FileName))
            {
                string connectionString = "DefaultEndpointsProtocol=https;AccountName=appkacvstorage;AccountKey=1F5gXDzX5zatwbVzvCisref6iHMqZlHl40txPt/O6Z+Lp0qXJ23/aulzauz3TCQEcLCHkxuXLyWRCSPaTHh4Jg==;EndpointSuffix=core.windows.net";

                CloudStorageAccount account = CloudStorageAccount.Parse(connectionString);
                CloudBlobClient serviceClient = account.CreateCloudBlobClient();
                var container = serviceClient.GetContainerReference("myblobson");

                string extension = Path.GetExtension(application.FileName);
                string name = DateTime.Now.ToString().Replace(" ", "-").Replace("/", "-").Replace(":", "-").Replace(".", "-") + extension;
                CloudBlockBlob blob = container.GetBlockBlobReference(name);
                application.FileName = name;
                int index = application.FileData.IndexOf(',');
                string data = application.FileData.Substring(index + 1);
                data = data.Replace("\\", "\\\\");
                var bytes = Convert.FromBase64String(data);
                using (var stream = new MemoryStream(bytes))
                {
                    blob.UploadFromStreamAsync(stream).Wait();
                }
            }

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
