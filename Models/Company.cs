using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class Company
    {
        public int Id { get; set; }

        [StringLength(55, ErrorMessage = "The Company Name must be less than 55 characters.")]
        public string CompanyName { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }

        [StringLength(255, ErrorMessage = "The About Use must be less than 255 characters.")]
        public string AboutUs { get; set; }
        public List<Job> Jobs { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
