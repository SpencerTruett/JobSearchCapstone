using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int LocationId { get; set; }
        public string AboutUs { get; set; }
    }
}
