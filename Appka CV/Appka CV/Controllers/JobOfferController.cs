using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appka_CV.Models;

namespace Appka_CV.Controllers
{

    public class JobOfferController : Controller
    {
        private static List<JobOffer> _jobOffers = new List<JobOffer>
        {
            new JobOffer { Id = 1, JobTitle = "Backend Developer" },
            new JobOffer { Id = 2, JobTitle = "Frontend Developer" },
            new JobOffer { Id = 3, JobTitle = "Manager" },
            new JobOffer { Id = 4, JobTitle = "Teacher" },
            new JobOffer { Id = 5, JobTitle = "Cook" }
        };

        public ViewResult Index()
        {
            return View(_jobOffers);
        }

        public ViewResult Details(int id)
        {
            return View(_jobOffers.Where(e => e.Id == id).FirstOrDefault());

        }
    }
}
