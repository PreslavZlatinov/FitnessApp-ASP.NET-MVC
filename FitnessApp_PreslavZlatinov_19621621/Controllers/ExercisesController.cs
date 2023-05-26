using Microsoft.AspNetCore.Mvc;

namespace FitnessApp_PreslavZlatinov_19621621.Controllers
{
    public class ExercisesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
