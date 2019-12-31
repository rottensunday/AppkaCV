using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Appka_CV_API.Models
{
    public class EFApplicationsRepository
    {
        private DataContext context;
        public EFApplicationsRepository(DataContext ctx) => context = ctx;
        public IQueryable<JobApplication> Applications => context.JobApplications.Include(application => application.JobOffer);
        public void SaveApplication(JobApplication application)
        {
            if (application.Id == 0)
            {
                context.JobApplications.Add(application);
            }

            else
            {
                JobApplication applicationEntry = context.JobApplications.FirstOrDefault(x => x.Id == application.Id);
                if (applicationEntry != null)
                {
                    applicationEntry.Accepted = application.Accepted;
                    applicationEntry.Address = application.Address;
                    applicationEntry.EmailAddress = application.EmailAddress;
                    applicationEntry.FirstFile = application.FirstFile;
                    applicationEntry.FirstName = application.FirstName;
                    applicationEntry.Hobbies = application.Hobbies;
                    applicationEntry.Id = application.Id;
                    applicationEntry.JobOffer = application.JobOffer;
                    applicationEntry.Languages = application.Languages;
                    applicationEntry.LastName = application.LastName;
                    applicationEntry.PhoneNumber = application.PhoneNumber;
                    applicationEntry.SecondFile = application.SecondFile;
                    applicationEntry.Skills = application.Skills;
                    applicationEntry.ThirdFile = application.ThirdFile;
                    applicationEntry.Education = application.Education;
                    applicationEntry.User = application.User;

                }
            }
            context.SaveChanges();
        }

        public JobApplication DeleteApplication(int applicationId)
        {
            JobApplication applicationEntry = context.JobApplications.FirstOrDefault(x => x.Id == applicationId);
            if(applicationEntry != null)
            {
                context.JobApplications.Remove(applicationEntry);
                context.SaveChanges();
            }
            return applicationEntry;
        }
    }
}