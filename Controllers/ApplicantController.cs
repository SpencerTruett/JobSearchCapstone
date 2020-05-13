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
                .Include(aj => aj.ApplicantJobs)
                .ToListAsync();

            var applicantJobs = await _context.ApplicantJob
                .Include(j => j.Job)
                .Where(a => a.Applicant.ApplicationUser.Id == user.Id)
                .ToListAsync();

            var applicant = await _context.Applicant
                .Include(a => a.ApplicationUser)
                .ThenInclude(l => l.Location)
                .FirstOrDefaultAsync(a => a.Id == user.ApplicantId);

            viewModel.ApplicantJobs = applicantJobs;
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
        public async Task<ActionResult> Create(int id)
        {
            try
            {
                // TODO: Add insert logic here

                var user = await GetCurrentUserAsync();

                var jobApplication = new ApplicantJob
                {
                    ApplicantId = user.ApplicantId,
                    JobId = id
                };
                _context.Add(jobApplication);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Applicant");
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
        public async Task<IActionResult> Edit(int id, ApplicantPersonalInfoViewModel viewModel)
        {
            try
            {
                var user = await _context.ApplicationUsers
                    .Include(a => a.Applicant)
                    .FirstOrDefaultAsync(a => a.Id == viewModel.ApplicationUser.Id);

                user.FirstName = viewModel.ApplicationUser.FirstName;
                user.LastName = viewModel.ApplicationUser.LastName;
                user.LocationId = viewModel.ApplicationUser.LocationId;
                user.Applicant.Email = viewModel.Applicant.Email;
                user.Applicant.SocialLink = viewModel.Applicant.SocialLink;
                user.Applicant.ImagePath = viewModel.Applicant.ImagePath;
                user.Applicant.Education = viewModel.Applicant.Education;
                user.Applicant.Experience = viewModel.Applicant.Experience;
                user.Applicant.SkillsAndCertifications = viewModel.Applicant.SkillsAndCertifications;
                user.Applicant.ResumePath = viewModel.Applicant.ResumePath;

                var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images");
                if (viewModel.ImageFile != null)
                {
                    var fileName = Guid.NewGuid().ToString() + viewModel.ImageFile.FileName;
                    user.Applicant.ImagePath = fileName;
                    using (var fileStream = new FileStream(Path.Combine(uploadPath, fileName), FileMode.Create))
                    {
                        await viewModel.ImageFile.CopyToAsync(fileStream);
                    }
                }
                //else if (viewModel.ImageFile != null)
                //{
                //    user.Applicant.ImagePath = viewModel.ImageFile.ToString();
                //}
                if (viewModel.ResumeFile != null)
                {
                    var fileName = Guid.NewGuid().ToString() + viewModel.ResumeFile.FileName;
                    user.Applicant.ResumePath = fileName;
                    using (var fileStream = new FileStream(Path.Combine(uploadPath, fileName), FileMode.Create))
                    {
                        await viewModel.ResumeFile.CopyToAsync(fileStream);
                    }
                }
                //else if (viewModel.ResumeFile != null)
                //{
                //    user.Applicant.ResumePath = viewModel.ResumeFile.ToString();
                //}


                _context.ApplicationUsers.Update(user);
                await _context.SaveChangesAsync();

            }
            catch(Exception ex)
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
        public async Task<ActionResult> Delete(int id, ApplicantJob applicantJob)
        {
            try
            {
                // TODO: Add delete logic here
                _context.ApplicantJob.Remove(applicantJob);
                await _context.SaveChangesAsync();

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