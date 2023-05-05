using FitnessApp_PreslavZlatinov_19621621.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp_PreslavZlatinov_19621621.Controllers
{
    public class WorkoutTypesController : Controller
    {

        private readonly AppDbContext _context;

        public WorkoutTypesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allWorkoutTypes = await _context.WorkoutTypes.ToListAsync();
            return View(allWorkoutTypes);
        }
    }
}
