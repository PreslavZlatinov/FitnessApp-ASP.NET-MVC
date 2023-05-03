using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessApp_PreslavZlatinov_19621621.Models
{
    public class Athlete
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }

        public string Bio { get; set; }

        //Relationships

        public List<Athlete_Workout> Athletes_Workouts { get; set; }
    }
}
