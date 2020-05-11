using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models.ViewModels
{
    public class ApplicantPersonalInfoViewModel
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public Applicant Applicant { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int? LocationId { get; set; }
        public List<SelectListItem> LocationOptions { get; set; }
    }
}
