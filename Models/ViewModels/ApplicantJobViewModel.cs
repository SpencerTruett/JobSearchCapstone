using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models.ViewModels
{
    public class ApplicantJobViewModel
    {
        public int Id { get; set; }
        public Applicant Applicant { get; set; }
        public List<ApplicantJob> ApplicantJobs { get; set; }
        public Job Job { get; set; }
        public List<Job> Jobs { get; set; }
        public ApplicantJob ApplicantJob { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
