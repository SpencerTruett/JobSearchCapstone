using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Extensions.Logging;

namespace JobSearch.Controllers
{
    public class EmployerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public EmployerController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Employer
        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();
            var jobs = await _context.Job
                .Where(j => j.CompanyId == user.CompanyId)
                .Include(c => c.Company)
                .Include(et => et.EmploymentType)
                .Include(ca => ca.Category)
                .ToListAsync();

            return View(jobs);
        }

        // GET: Employer/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var job = await _context.Job
                .Include(c => c.Company)
                .Include(et => et.EmploymentType)
                .Include(ca => ca.Category)
                .FirstOrDefaultAsync(j => j.Id == id);

            return View(job);
        }

        // GET: Employer/Create
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

        // POST: Employer/Create
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

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}