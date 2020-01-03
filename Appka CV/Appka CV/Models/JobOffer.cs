using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Appka_CV.Models
{
    public class JobOffer
    {
        public int Id { get; set; }
        [Required]
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public Company Company { get; set; }
        public string Category { get; set; }
        public string Position { get; set; }
        public string SalaryFrom { get; set; }
        public string SalaryTo { get; set; }
        public string City { get; set; }
        public string FileName { get; set; }
        public string HR { get; set; }
        [NotMapped]
        public string FileData { get; set; }
        [NonSerialized]
        public List<JobApplication> jobApplications;
        [NotMapped]
        public bool HasApplied { get; set; }
        [NotMapped]
        public int ApplicationId { get; set; }
    }
}
