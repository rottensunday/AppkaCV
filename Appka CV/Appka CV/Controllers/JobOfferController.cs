using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appka_CV.Models;
using Appka_CV.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

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

        [Authorize(Policy = "HROnly")]
        [HttpGet]
        public ViewResult AddOffer(int id)
        {
            return View(id);
        }
    }
}
