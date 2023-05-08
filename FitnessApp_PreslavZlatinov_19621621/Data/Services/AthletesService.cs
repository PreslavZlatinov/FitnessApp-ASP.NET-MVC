using FitnessApp_PreslavZlatinov_19621621.Data.Base;
using FitnessApp_PreslavZlatinov_19621621.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp_PreslavZlatinov_19621621.Data.Services
{
    public class AthletesService : EntityBaseRepository<Athlete>, IAthletesService
    {
        public AthletesService(AppDbContext context) : base(context) { }
    }
}
