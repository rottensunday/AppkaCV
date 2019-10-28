using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appka_CV.Models
{
    public class JobApplication
    {
        public int Id { get; set; }
        public JobOffer JobOffer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Skills { get; set; }
        public string Hobbies { get; set; }
        public string Languages { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        //public bool ContactAgreement { get; set; }
        public bool Accepted { get; set; }
        public string FirstFile { get; set; }
        public string SecondFile { get; set; }
        public string ThirdFile { get; set; }
    }
}
