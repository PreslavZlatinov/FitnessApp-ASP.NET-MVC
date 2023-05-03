using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessApp_PreslavZlatinov_19621621.Models
{
    public class Athlete_Workout
    {
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }

        public int AthleteId { get; set; }
        public Athlete Athlete { get; set; }
    }
}
