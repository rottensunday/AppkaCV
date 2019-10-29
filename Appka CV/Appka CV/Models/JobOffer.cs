﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appka_CV.Models
{
    public class JobOffer
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public Company Company { get; set; }
        public string Category { get; set; }
        public string Position { get; set; }
        public string SalaryFrom { get; set; }
        public string SalaryTo { get; set; }
        public string City { get; set; }
        public string ImageFile { get; set; }

        public List<JobApplication> JobApplications { get; set; }
    }
}