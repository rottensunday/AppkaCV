﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Appka_CV.Models
{
    public class JobApplication
    {
        public int Id { get; set; }
        public JobOffer JobOffer { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Education { get; set; }
        public string Skills { get; set; }
        public string Hobbies { get; set; }
        public string Languages { get; set; }
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public bool Accepted { get; set; }
        public string FileName { get; set; }
        [NotMapped]
        public string FileData { get; set; }
        public string User { get; set; }
    }
}
