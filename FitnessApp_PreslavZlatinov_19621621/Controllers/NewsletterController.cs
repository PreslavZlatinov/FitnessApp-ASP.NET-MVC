using FitnessApp_PreslavZlatinov_19621621.Data.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp_PreslavZlatinov_19621621.Controllers
{
    public class NewsletterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SubscriptionCompleted()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe()
        {
            return View("SubscriptionCompleted");
        }
    }
}
