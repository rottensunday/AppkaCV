using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appka_CV.Models;
using Appka_CV.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Appka_CV.Controllers
{

    public class JobOfferController : Controller
    {

        private EFJobOffersRepository JobOffersRepository { get; set; }
        private EFCompaniesRepository CompaniesRepository { get; set; }
        public JobOfferController(EFJobOffersRepository repo1, EFCompaniesRepository repo2)
        {
            JobOffersRepository = repo1;
            CompaniesRepository = repo2;
        }

        public ViewResult Index()
        {
            return View(JobOffersRepository.JobOffers);
        }

        [HttpGet]
        public ViewResult AddOffer(int offerId)
        {
            return View(offerId == 0 ? 
                new JobOfferViewModel() { JobOffer = new JobOffer(), Companies = CompaniesRepository.Companies, SelectedCompany = 1}
                : new JobOfferViewModel() { JobOffer = JobOffersRepository.JobOffers.Where(x => x.Id == offerId).FirstOrDefault(),
                    Companies = CompaniesRepository.Companies, SelectedCompany = JobOffersRepository.JobOffers.Where(x => x.Id == offerId).FirstOrDefault().Company.Id });
        }

        [HttpPost]
        public IActionResult AddOffer(JobOfferViewModel offerModel)
        {
            if (ModelState.IsValid)
            {
                JobOffer offer = offerModel.JobOffer;
                offer.Company = CompaniesRepository.Companies.Where(x => x.Id == offerModel.SelectedCompany).FirstOrDefault();
                JobOffersRepository.SaveOffer(offer);
                return RedirectToAction("Index");
            }
            else
            {
                return View(offerModel);
            }
        }

        //public ViewResult Details(int id)
        //{
        //    return View(_jobOffers.Where(e => e.Id == id).FirstOrDefault());

        //}
    }
}
