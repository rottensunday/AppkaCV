using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appka_CV.Models
{
    public class EFCompaniesRepository
    {
        private DataContext context;
        public EFCompaniesRepository(DataContext ctx) => context = ctx;
        public IQueryable<Company> Companies => context.Companies;
        public void SaveCompany(Company company)
        {
            if(company.Id == 0)
            {
                context.Companies.Add(company);
            }

            else
            {
                Company companyEntry = context.Companies.FirstOrDefault(x => x.Id == company.Id);
                if(companyEntry != null)
                {
                    companyEntry.Name = company.Name;
                }
            }

            context.SaveChanges();
        }

        public Company DeleteCompany(int companyId)
        {
            Company companyEntry = context.Companies.FirstOrDefault(x => x.Id == companyId);
            if(companyEntry != null)
            {
                context.Companies.Remove(companyEntry);
                context.SaveChanges();
            }

            return companyEntry;
        }
    }
}
