using FitnessApp_PreslavZlatinov_19621621.Data;
using FitnessApp_PreslavZlatinov_19621621.Data.Services;
using FitnessApp_PreslavZlatinov_19621621.Data.Static;
using FitnessApp_PreslavZlatinov_19621621.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace FitnessApp_PreslavZlatinov_19621621.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class SponsorsController : Controller
    {

        private readonly ISponsorsService _service;

        public SponsorsController(ISponsorsService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allSponsors = await _service.GetAllAsync();
            return View(allSponsors);
        }

        //GET: Sponsors/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var sponsorDetails = await _service.GetByIdAsync(id);
            if (sponsorDetails == null) return View("NotFound");
            return View(sponsorDetails);
        }

        //GET: Sponsors/Create

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")]Sponsor sponsor)
        {
            if (!ModelState.IsValid)
            {
                return View(sponsor);
            }

            await _service.AddAsync(sponsor);

            return RedirectToAction(nameof(Index));
        }

        //GET: Sponsors/Edit

        public async Task<IActionResult> Edit(int id)
        {
            var sponsorDetails = await _service.GetByIdAsync(id);
            if (sponsorDetails == null) return View("NotFound");
            return View(sponsorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Sponsor sponsor)
        {
            if (!ModelState.IsValid)
            {
                return View(sponsor);
            }

            if(id == sponsor.Id)
            {
                await _service.UpdateAsync(id, sponsor);

                return RedirectToAction(nameof(Index));
            }

            return View(sponsor);
        }

        //GET: Sponsors/Delete/1

        public async Task<IActionResult> Delete(int id)
        {
            var sponsorDetails = await _service.GetByIdAsync(id);
            if (sponsorDetails == null) return View("NotFound");
            return View(sponsorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sponsorDetails = await _service.GetByIdAsync(id);
            if (sponsorDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
