using FitnessApp_PreslavZlatinov_19621621.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp_PreslavZlatinov_19621621.Controllers
{
    public class SponsorsController : Controller
    {

        private readonly AppDbContext _context;

        public SponsorsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allSponsors = await _context.Sponsors.ToListAsync();
            return View(allSponsors);
        }
    }
}
