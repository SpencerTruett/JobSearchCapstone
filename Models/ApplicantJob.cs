using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class ApplicantJob
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int JobId { get; set; }
        public bool IsAccepted { get; set; }
    }
}
