using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace JobSearch.Models.ViewModels
{
    public class JobEmploymentTypeViewModel
    {
        public int Id { get; set; }
        public Job Job { get; set; }
        public int? EmploymentTypeId { get; set; }
        public int? CategoryId { get; set; }
        public List<SelectListItem> EmploymentTypeOptions { get; set; }
        public List<SelectListItem> CategoryOptions { get; set; }
    }
}
