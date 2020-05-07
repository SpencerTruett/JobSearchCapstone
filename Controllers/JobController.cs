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
        public ActionResult Index()
        {
            return View();
        }

        // GET: Job/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var job = await _context.Job
                .Include(c => c.Company)
                .Include(et => et.EmploymentType)
                .Include(ca => ca.Category)
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
            var job = await _context.Job.FindAsync(id);

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
                _context.Update(job);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

            }
            return RedirectToAction("Index", "Employer");
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

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}