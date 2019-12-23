using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appka_CV.Models;

namespace Appka_CV.Controllers
{
    public class AdministratorController : Controller
    {
        private EFCompaniesRepository CompaniesRepository { get; set; }
        public AdministratorController(EFCompaniesRepository repo1)
        {
            CompaniesRepository = repo1;
        }
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult ListCompanies()
        {
            return View(CompaniesRepository.Companies);
        }

        [HttpGet]
        public ViewResult AddCompany(int id)
        {
            return View(id);
        }

        //[HttpPost]
        //public IActionResult AddCompany(Company company)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        CompaniesRepository.SaveCompany(company);
        //        return RedirectToAction("ListCompanies");
        //    }
        //    else
        //    {
        //        return View(company);
        //    }
        //}

        [HttpPost]
        public IActionResult DeleteCompany(int id)
        {
            if (ModelState.IsValid)
            {
                CompaniesRepository.DeleteCompany(id);
                return RedirectToAction("ListCompanies");
            }
            else
            {
                return View("ListCompanies");
            }
        }
    }
}
