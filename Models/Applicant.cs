using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class Applicant
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string SocialLink { get; set; }

        [StringLength(500, ErrorMessage = "The Education must be less than 500 characters.")]
        public string Education { get; set; }

        [StringLength(500, ErrorMessage = "The Experience must be less than 500 characters.")]
        public string Experience { get; set; }
        public string SkillsAndCertifications { get; set; }
        public string ResumePath { get; set; }
        public string Email { get; set; }
        public List<ApplicantJob> ApplicantJobs { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int JobId { get; set; }
    }
}
