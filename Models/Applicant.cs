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
        public string Image { get; set; }
        public string SocialLink { get; set; }

        [StringLength(255, ErrorMessage = "The Education must be less than 255 characters.")]
        public string Education { get; set; }

        [StringLength(255, ErrorMessage = "The Experience must be less than 255 characters.")]
        public string Experience { get; set; }
        public string SkillsAndCertifications { get; set; }
        public string Resume { get; set; }
        public List<ApplicantJob> ApplicantJobs { get; set; }
    }
}
