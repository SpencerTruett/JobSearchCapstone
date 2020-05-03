using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class User
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int ApplicantId { get; set; }
        public bool IsEmployer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int LocationId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
