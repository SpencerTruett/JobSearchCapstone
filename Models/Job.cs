using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class Job
    {
        public int Id { get; set; }

        [StringLength(55, ErrorMessage = "The Position must be less than 55 characters.")]
        public string Position { get; set; }

        [StringLength(255, ErrorMessage = "The Description must be less than 255 characters.")]
        public string Description { get; set; }
        public string Salary { get; set; }
        public string YearsOfExperience { get; set; }
        public int? EmploymentTypeId { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ApplicantJob> ApplicantJobs { get; set; }
    }
}
