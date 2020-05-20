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
        [Required(ErrorMessage = "Position is a Required Field")]
        [StringLength(55, ErrorMessage = "The Position must be less than 55 characters.")]
        //[RegularExpression(@"^[0-9a-zA-Z''-'\s]{1,256}$", ErrorMessage = "Special characters are not allowed.")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Description is a Required Field")]
        [StringLength(255, ErrorMessage = "The Description must be less than 255 characters.")]
        //[RegularExpression(@"^[0-9a-zA-Z''-'\s]{1,256}$", ErrorMessage = "Special characters are not allowed.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Salary is a Required Field")]
        public string Salary { get; set; }
        [Required(ErrorMessage = "Experience is a Required Field")]
        public string YearsOfExperience { get; set; }
        
        public int? EmploymentTypeId { get; set; }
        [Required(ErrorMessage = "Employment Type is a Required Field")]
        public EmploymentType EmploymentType { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
        public int? CategoryId { get; set; }
        [Required(ErrorMessage = "Category is a Required Field")]
        public Category Category { get; set; }
        public List<ApplicantJob> ApplicantJobs { get; set; }
    }
}
