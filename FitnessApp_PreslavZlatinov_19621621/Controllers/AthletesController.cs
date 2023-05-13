using FitnessApp_PreslavZlatinov_19621621.Data;
using FitnessApp_PreslavZlatinov_19621621.Data.Services;
using FitnessApp_PreslavZlatinov_19621621.Data.Static;
using FitnessApp_PreslavZlatinov_19621621.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace FitnessApp_PreslavZlatinov_19621621.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class AthletesController : Controller
    {

        private readonly IAthletesService _service;

        public AthletesController(IAthletesService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Athletes/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Athlete athlete)
        {
            if (!ModelState.IsValid)
            {
                return View(athlete);
            }

            await _service.AddAsync(athlete);

            return RedirectToAction(nameof(Index));
        }

        //Get: Athletes/Details/ID
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var athleteDetails = await _service.GetByIdAsync(id);

            if (athleteDetails == null) return View("NotFound");
            return View(athleteDetails);
        }

        //Get: Athletes/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var athleteDetails = await _service.GetByIdAsync(id);

            if (athleteDetails == null) return View("NotFound");
            return View(athleteDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Athlete athlete)
        {

            if (!ModelState.IsValid)
            {
                return View(athlete);
            }

            await _service.UpdateAsync(id, athlete);

            return RedirectToAction(nameof(Index));
        }

        //Get: Athletes/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var athleteDetails = await _service.GetByIdAsync(id);

            if (athleteDetails == null) return View("NotFound");
            return View(athleteDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var athleteDetails = await _service.GetByIdAsync(id);

            if (athleteDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
