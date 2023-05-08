using FitnessApp_PreslavZlatinov_19621621.Data.Base;
using FitnessApp_PreslavZlatinov_19621621.Models;

namespace FitnessApp_PreslavZlatinov_19621621.Data.Services
{
    public class SponsorsService: EntityBaseRepository<Sponsor>, ISponsorsService
    {
        public SponsorsService(AppDbContext context) : base(context)
        {
            
        }
    }
}
