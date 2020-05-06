using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int? LocationId { get; set; }
        public Location Location { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
        public int? ApplicantId { get; set; }
        public Applicant Applicant { get; set; }
        public bool IsEmployer { get; set; }
    }
}
