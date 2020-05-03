using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class Applicant
    {
        public int Id { get; set; }
        public string image { get; set; }
        public string SocialLink { get; set; }
        public string Education { get; set; }
        public string Experience { get; set; }
        public string SkillsAndCertifications { get; set; }
        public string Resume { get; set; }
    }
}
