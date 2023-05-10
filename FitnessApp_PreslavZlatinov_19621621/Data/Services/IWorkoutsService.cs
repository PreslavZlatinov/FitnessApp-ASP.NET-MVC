using FitnessApp_PreslavZlatinov_19621621.Data.Base;
using FitnessApp_PreslavZlatinov_19621621.Data.ViewModels;
using FitnessApp_PreslavZlatinov_19621621.Models;

namespace FitnessApp_PreslavZlatinov_19621621.Data.Services
{
    public interface IWorkoutsService:IEntityBaseRepository<Workout>
    {
        Task<Workout> GetWorkoutByIdAsync(int id);
        Task<NewWorkoutDropdownsVM> GetNewWorkoutDropdownsValues();

        Task AddNewWorkoutAsync(NewWorkoutVM data);

        Task UpdateWorkoutAsync(NewWorkoutVM data);
    }
}
