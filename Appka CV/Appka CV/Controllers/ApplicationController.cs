using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Appka_CV.Models;
using Appka_CV.Models.ViewModels;

namespace Appka_CV.Controllers
{
    public class ApplicationController : Controller
    {
        private EFApplicationsRepository ApplicationsRepository { get; set; }
        private EFJobOffersRepository JobOffersRepository { get; set; }
        public ApplicationController(EFApplicationsRepository repo1, EFJobOffersRepository repo2)
        {
            ApplicationsRepository = repo1;
            JobOffersRepository = repo2;
        }

        public ViewResult Index() => View(ApplicationsRepository.Applications.Include(x => x.JobOffer).ThenInclude(x=> x.Company));

        [HttpGet]
        public ViewResult AddApplication(int id, int jobOffer)
        {
            string offerTitle = JobOffersRepository.JobOffers.FirstOrDefault(x => x.Id == jobOffer)?.JobTitle ?? "";
            return View((id, jobOffer, offerTitle));
        }

        [HttpPost]
        public IActionResult AddApplication(JobApplicationViewModel applicationModel)
        {
            //if (ModelState.IsValid)
            //{
            //    JobApplication jobApplication = applicationModel.Application;
            //    jobApplication.JobOffer = JobOffersRepository.JobOffers.Where(x => x.Id == applicationModel.JobOffer.Id).FirstOrDefault();
            //    ApplicationsRepository.SaveApplication(jobApplication);
            //    return RedirectToAction("Index");
            //}
            //else
            //{
                return View(applicationModel);
            //}
        }

        [HttpPost]
        public IActionResult DeleteApplication(int id)
        {
            if (ModelState.IsValid)
            {
                ApplicationsRepository.DeleteApplication(id);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }
        }
    }
}
