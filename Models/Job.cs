using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string Salary { get; set; }
        public string YearsOfExperience { get; set; }
        public int EmploymentTypeId { get; set; }
        public int CompanyId { get; set; }
    }
}
