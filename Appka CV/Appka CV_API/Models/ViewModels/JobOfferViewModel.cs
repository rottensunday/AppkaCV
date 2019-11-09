using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appka_CV_API.Models.ViewModels
{
    public class JobOfferViewModel
    {
        public JobOffer JobOffer { get; set; }
        public IEnumerable<Company> Companies { get; set; }
        public int? SelectedCompany { get; set; }
    }
}
