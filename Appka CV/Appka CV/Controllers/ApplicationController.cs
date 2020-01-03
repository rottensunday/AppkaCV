using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Appka_CV.Models;
using Appka_CV.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Appka_CV.Controllers
{
    [Authorize]
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
    }
}
