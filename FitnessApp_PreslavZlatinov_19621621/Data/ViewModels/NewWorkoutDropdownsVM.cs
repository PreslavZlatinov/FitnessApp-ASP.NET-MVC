using FitnessApp_PreslavZlatinov_19621621.Models;

namespace FitnessApp_PreslavZlatinov_19621621.Data.ViewModels
{
    public class NewWorkoutDropdownsVM
    {
        public NewWorkoutDropdownsVM()
        {
            Sponsors = new List<Sponsor>();
            WorkoutTypes = new List<WorkoutType>();
            Athletes = new List<Athlete>();
        }

        public List<Sponsor> Sponsors { get; set; }
        public List<WorkoutType> WorkoutTypes { get; set; }
        public List<Athlete> Athletes { get; set; }
    }
}
