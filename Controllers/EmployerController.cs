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

            var viewModel = new CompanyJobViewModel();


            viewModel.Jobs = await _context
                .Job
                .Select(j => new JobsWithCountViewModel()
                {
                    JobId = j.Id,
                    Position = j.Position,
                    Description = j.Description,
                    Salary = j.Salary,
                    YearsOfExperience = j.YearsOfExperience,
                    EmploymentTypeId = j.EmploymentTypeId,
                    EmploymentTypeName = j.EmploymentType.Name,
                    CategoryId = j.CategoryId,
                    CategoryName = j.Category.Label,
                    CompanyId = j.CompanyId,
                    Company = j.Company,
                    CompanyName = j.Company.CompanyName,
                    CompanyLocation = j.Company.Location.Name,
                    CompanyAboutUs = j.Company.AboutUs,
                    ApplicantCount = j.ApplicantJobs.Count()
                })
                .Where(c => c.Company.ApplicationUser.Id == user.Id)
                .ToListAsync();

            viewModel.Company = await _context.Company
                .Include(a => a.ApplicationUser)
                .ThenInclude(l => l.Location)
                .FirstOrDefaultAsync(c => c.Id == user.CompanyId);

            return View(viewModel);
        }

        // GET: Employer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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