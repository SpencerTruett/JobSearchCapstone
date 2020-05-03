using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class ApplicantJob
    {
        public int Id { get; set; }
        public int ApplicationUserId { get; set; }
        public ApplicationUser applicationUser { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }
        public bool IsAccepted { get; set; }
    }
}
