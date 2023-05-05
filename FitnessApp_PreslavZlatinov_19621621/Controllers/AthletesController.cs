using FitnessApp_PreslavZlatinov_19621621.Data;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp_PreslavZlatinov_19621621.Controllers
{
    public class AthletesController : Controller
    {

        private readonly AppDbContext _context;

        public AthletesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Athletes.ToList();
            return View(data);
        }
    }
}
