using FitnessApp_PreslavZlatinov_19621621.Data.Base;
using FitnessApp_PreslavZlatinov_19621621.Models;

namespace FitnessApp_PreslavZlatinov_19621621.Data.Services
{
    public class WorkoutTypesService:EntityBaseRepository<WorkoutType>, IWorkoutTypesService
    {
        public WorkoutTypesService(AppDbContext context) : base(context)
        {
            
        }
    }
}
