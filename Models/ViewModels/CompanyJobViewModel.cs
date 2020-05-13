using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models.ViewModels
{
    public class CompanyJobViewModel 
    {
        public List<JobsWithCountViewModel> Jobs { get; set; }
        public Company Company { get; set; }
    }
}
