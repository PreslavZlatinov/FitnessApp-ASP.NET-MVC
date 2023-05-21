using FitnessApp_PreslavZlatinov_19621621.Data.Base;
using FitnessApp_PreslavZlatinov_19621621.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessApp_PreslavZlatinov_19621621.Models
{
    public class Workout:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageURL { get; set; }

        public Gender Gender { get; set; }

        public int Days { get; set; }

        public string Goal { get; set; }

        public string Equipment { get; set; }

        public WorkoutExperience WorkoutExperience { get; set; }

        //Relationships

        public List<Athlete_Workout> Athletes_Workouts { get; set; }

        //WorkoutType
        public int WorkoutId { get; set; }
        [ForeignKey("WorkoutId")]
        public WorkoutType WorkoutType { get; set; }

        //Sponsor
        public int SponsorId { get; set; }
        [ForeignKey("SponsorId")]
        public Sponsor Sponsor { get; set; }
    }
}
