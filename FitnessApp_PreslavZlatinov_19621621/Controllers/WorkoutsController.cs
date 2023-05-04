using FitnessApp_PreslavZlatinov_19621621.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp_PreslavZlatinov_19621621.Controllers
{
    public class WorkoutsController : Controller
    {
        private readonly AppDbContext _context;

        public WorkoutsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allWorkouts = await _context.Workouts.ToListAsync();
            return View();
        }
    }
}
