using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearch.Data;
using JobSearch.Models;
using JobSearch.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace JobSearch.Controllers
{
    public class JobController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public JobController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Job
        public async Task<IActionResult> Index(string positionSearchString, string companySearchString, string categorySearchString, string locationSearchString)
        {
            var user = await GetCurrentUserAsync();
            var jobs = from j in _context.Job
                .Include(c => c.Company)
                .ThenInclude(l => l.Location)
                .Include(et => et.EmploymentType)
                .Include(ca => ca.Category)
                 select j;

                if (!String.IsNullOrEmpty(positionSearchString))
                {
                    jobs = jobs.Where(s => s.Position.Contains(positionSearchString));
                }

                if (!String.IsNullOrEmpty(companySearchString))
                {
                    jobs = jobs.Where(s => s.Company.CompanyName.Contains(companySearchString));
                }

                if (!String.IsNullOrEmpty(categorySearchString))
                {
                    jobs = jobs.Where(s => s.Category.Label.Contains(categorySearchString));
                }
            
                if (!String.IsNullOrEmpty(locationSearchString))
                {
                    jobs = jobs.Where(s => s.Company.Location.Name.Contains(locationSearchString));
                }


            return View(await jobs.ToListAsync());
        }

        // GET: Job/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var job = await _context.Job
                .Include(c => c.Company)
                .Include(et => et.EmploymentType)
                .Include(ca => ca.Category)
                .Include(aj => aj.ApplicantJobs)
                .ThenInclude(aj => aj.Applicant)
                .ThenInclude(au => au.ApplicationUser)
                .FirstOrDefaultAsync(j => j.Id == id);

            return View(job);
        }

        // GET: Job/Create
        public async Task<ActionResult> Create()
        {
            var viewModel = new JobEmploymentTypeViewModel();

            var employmentTypeOptions = await _context.EmploymentType.Select(et => new SelectListItem()
            {
                Text = et.Name,
                Value = et.Id.ToString()
            }).ToListAsync();

            var categoryOptions = await _context.Category.Select(ca => new SelectListItem()
            {
                Text = ca.Label,
                Value = ca.Id.ToString()
            }).ToListAsync();

            viewModel.EmploymentTypeOptions = employmentTypeOptions;
            viewModel.CategoryOptions = categoryOptions;

            return View(viewModel);
        }

        // POST: Job/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(JobEmploymentTypeViewModel jobView)
        {
            try
            {
                var user = await GetCurrentUserAsync();

                var jobPost = new Job
                {
                    Position = jobView.Job.Position,
                    Description = jobView.Job.Description,
                    Salary = jobView.Job.Salary,
                    YearsOfExperience = jobView.Job.YearsOfExperience,
                    EmploymentTypeId = jobView.EmploymentTypeId,
                    CategoryId = jobView.CategoryId,
                    CompanyId = user.CompanyId
                };
                _context.Add(jobPost); 
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Employer");
            }
            catch
            {
                return View();
            }
        }

        // GET: Job/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var viewModel = new JobEmploymentTypeViewModel();
            var job = await _context.Job.FirstOrDefaultAsync(j => j.Id == id);

            var employmentTypeOptions = await _context.EmploymentType.Select(et => new SelectListItem()
            {
                Text = et.Name,
                Value = et.Id.ToString()
            }).ToListAsync();

            var categoryOptions = await _context.Category.Select(ca => new SelectListItem()
            {
                Text = ca.Label,
                Value = ca.Id.ToString()
            }).ToListAsync();

            viewModel.EmploymentTypeOptions = employmentTypeOptions;
            viewModel.CategoryOptions = categoryOptions;
            viewModel.Id = job.Id;
            viewModel.Job = job;

            if (id == null)
            {
                return NotFound();
            }

            if (viewModel == null)
            {
                return NotFound();
            }
            return View(viewModel);
        }

        // POST: Job/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Job job)
        {
            try
            {
                var user = await GetCurrentUserAsync();

                var singleJob = await _context.Job
                .Include(c => c.Company)
                .Include(et => et.EmploymentType)
                .Include(ca => ca.Category)
                .Include(aj => aj.ApplicantJobs)
                .ThenInclude(aj => aj.Applicant)
                .ThenInclude(au => au.ApplicationUser)
                .FirstOrDefaultAsync(j => j.Id == id);


                singleJob.Position = job.Position;
                singleJob.Description = job.Description;
                singleJob.Salary = job.Salary;
                singleJob.YearsOfExperience = job.YearsOfExperience;
                singleJob.EmploymentTypeId = job.EmploymentTypeId;
                singleJob.CategoryId = job.CategoryId;
                singleJob.CompanyId = user.CompanyId;
                

                _context.Update(singleJob);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Employer");
            }
            catch (DbUpdateConcurrencyException)
            {
                return View();
            }
        }

        // GET: Job/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var job = await _context.Job
                .Include(c => c.Company)
                .Include(et => et.EmploymentType)
                .Include(ca => ca.Category)
                .FirstOrDefaultAsync(j => j.Id == id);

            var loggedInUser = await GetCurrentUserAsync();

            if (job.CompanyId != loggedInUser.CompanyId)
            {
                return NotFound();
            }

            return View(job);
        }

        // POST: Job/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, Job job)
        {
            try
            {
                _context.Job.Remove(job);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Employer");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Accept(ApplicantJob acceptApplication)
        {
            try
            {
                var user = await GetCurrentUserAsync();

                var singleAccept = new ApplicantJob
                {
                    IsAccepted = true,
                    IsDeclined = false
                };

                singleAccept.JobId = acceptApplication.Job.Id;
                singleAccept.ApplicantId = acceptApplication.Applicant.Id;

                _context.ApplicantJob.Update(singleAccept);
                await _context.SaveChangesAsync();

                return RedirectToAction("Details", "Products", new { id = acceptApplication.Id });
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Decline(ApplicantJob declineApplication)
        {
            try
            {
                var user = await GetCurrentUserAsync();

                var singleDecline = new ApplicantJob
                {
                    IsAccepted = false,
                    IsDeclined = true
                };

                singleDecline.JobId = declineApplication.Job.Id;
                singleDecline.ApplicantId = declineApplication.Applicant.Id;

                _context.ApplicantJob.Update(singleDecline);
                await _context.SaveChangesAsync();

                return RedirectToAction("Details", "Products", new { id = declineApplication.Id });
            }
            catch
            {
                return View();
            }
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}