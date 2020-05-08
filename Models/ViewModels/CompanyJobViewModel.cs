using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models.ViewModels
{
    public class CompanyJobViewModel 
    {
        public int Id { get; set; }
        public Company Company { get; set; }
        public List<Job> Jobs { get; set; }
        public Job Job { get; set; }
    }
}
