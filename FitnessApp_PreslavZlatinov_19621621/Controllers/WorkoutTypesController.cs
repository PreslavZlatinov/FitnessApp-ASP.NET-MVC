using FitnessApp_PreslavZlatinov_19621621.Data;
using FitnessApp_PreslavZlatinov_19621621.Data.Services;
using FitnessApp_PreslavZlatinov_19621621.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp_PreslavZlatinov_19621621.Controllers
{
    public class WorkoutTypesController : Controller
    {

        private readonly IWorkoutTypesService _service;

        public WorkoutTypesController(IWorkoutTypesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allWorkoutTypes = await _service.GetAllAsync();
            return View(allWorkoutTypes);
        }

        //GET: WorkoutTypes/Create

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")]WorkoutType workoutType)
        {
            if (!ModelState.IsValid) return View(workoutType);
            await _service.AddAsync(workoutType);
            return RedirectToAction(nameof(Index));
        }

        //GET: WorkoutTypes/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var workoutTypeDetails = await _service.GetByIdAsync(id);
            if (workoutTypeDetails == null) return View("NotFound");

            return View(workoutTypeDetails);
        }

        //GET: WorkoutTypes/Edit/1

        public async Task<IActionResult> Edit(int id)
        {
            var workoutTypeDetails = await _service.GetByIdAsync(id);
            if (workoutTypeDetails == null) return View("NotFound");

            return View(workoutTypeDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] WorkoutType workoutType)
        {
            if (!ModelState.IsValid) return View(workoutType);
            await _service.UpdateAsync(id, workoutType);
            return RedirectToAction(nameof(Index));
        }

        //GET: WorkoutTypes/Delete/1

        public async Task<IActionResult> Delete(int id)
        {
            var workoutTypeDetails = await _service.GetByIdAsync(id);
            if (workoutTypeDetails == null) return View("NotFound");

            return View(workoutTypeDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workoutTypeDetails = await _service.GetByIdAsync(id);
            if (workoutTypeDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
