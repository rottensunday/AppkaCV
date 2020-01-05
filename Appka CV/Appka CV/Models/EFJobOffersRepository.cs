using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Appka_CV.Models
{
    public class EFJobOffersRepository
    {
        private DataContext context;
        public EFJobOffersRepository(DataContext ctx) => context = ctx;
        public IQueryable<JobOffer> JobOffers => context.JobOffers.Include(joboffer => joboffer.Company);
        public void SaveOffer(JobOffer offer)
        {
            if (offer.Id == 0)
            {
                context.JobOffers.Add(offer);
            }

            else
            {
                JobOffer offerEntry = context.JobOffers.FirstOrDefault(x => x.Id == offer.Id);
                if (offerEntry != null)
                {
                    offerEntry.Category = offer.Category;
                    offerEntry.City = offer.City;
                    offerEntry.Company = offer.Company;
                    offerEntry.Description = offer.Description;
                    offerEntry.Id = offer.Id;
                    offerEntry.FileData = offer.FileData;
                    offerEntry.JobTitle = offer.JobTitle;
                    offerEntry.Position = offer.Position;
                    offerEntry.SalaryFrom = offer.SalaryFrom;
                }
            }

            context.SaveChanges();
        }

        public JobOffer DeleteOffer(int offerId)
        {
            JobOffer offerEntry = context.JobOffers.FirstOrDefault(x => x.Id == offerId);
            if (offerEntry != null)
            {
                context.JobOffers.Remove(offerEntry);
                context.SaveChanges();
            }

            return offerEntry;
        }

        public void AddApplication(JobOffer offer, JobApplication application)
        {
            if (offer != null && application != null)
            {
                JobOffer offerEntry = context.JobOffers.FirstOrDefault(x => x.Id == offer.Id);
                if (offerEntry != null)
                {
                //    offerEntry.jobApplications.Add(application);
                }
            }

            context.SaveChanges();
        }
    }
}
