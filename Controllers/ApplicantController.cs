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
    public class ApplicantController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicantController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Applicant
        public async Task<IActionResult> Index()
        {
            var viewModel = new ApplicantJobViewModel();

            var user = await GetCurrentUserAsync();
            var jobs = await _context.Job
                .Include(c => c.Company)
                .ThenInclude(l => l.Location)
                .Include(et => et.EmploymentType)
                .Include(ca => ca.Category)
                .ToListAsync();

            var applicant = await _context.Applicant
                .FirstOrDefaultAsync(a => a.Id == user.ApplicantId);

            viewModel.Jobs = jobs;
            viewModel.ApplicationUser = user;
            viewModel.Applicant = applicant;

            return View(viewModel);
        }

        // GET: Applicant/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var applicant = await _context.Applicant
                .Include(a => a.ApplicationUser)
                .ThenInclude(l => l.Location)
                .FirstOrDefaultAsync(a => a.Id == id);

            return View(applicant);
        }

        // GET: Applicant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Applicant/Create
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

        // GET: Applicant/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var user = await GetCurrentUserAsync();
            var viewModel = new ApplicantPersonalInfoViewModel();
            var applicant = await _context.Applicant.FirstOrDefaultAsync(a => a.Id == user.ApplicantId);

            if (applicant == null)
            {
                return NotFound();
            }

            var locationOptions = await _context.Location.Select(l => new SelectListItem()
            {
                Text = l.Name,
                Value = l.Id.ToString()
            }).ToListAsync();

            viewModel.LocationOptions = locationOptions;
            viewModel.Id = applicant.Id;
            viewModel.Applicant = applicant;
            viewModel.ApplicationUser = user;


            if (viewModel == null)
            {
                return NotFound();
            }
            return View(viewModel);
        }

        // POST: Applicant/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Applicant applicant, ApplicationUser user)
        {
            try
            {
                _context.Applicant.Update(applicant);
                await _context.SaveChangesAsync();
                _context.ApplicationUsers.Update(user);
                await _context.SaveChangesAsync();

            }
            catch
            {
                return View();
            }
            return RedirectToAction("Index", "Applicant");
        }

        // GET: Applicant/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Applicant/Delete/5
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