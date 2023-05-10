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
    public class NewWorkoutVM
    {

        public int Id { get; set; }

        [Display(Name = "Workout name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Workout Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Workout Price")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Workout ImageURL")]
        [Required(ErrorMessage = "ImageURL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Workout Days")]
        [Required(ErrorMessage = "Workout Days are required")]
        public int Days { get; set; }

        [Display(Name = "Workout Goal")]
        [Required(ErrorMessage = "Workout Goal is required")]
        public string Goal { get; set; }

        [Display(Name = "Select a WorkoutExperience")]
        [Required(ErrorMessage = "Workout Experience is required")]
        public WorkoutExperience WorkoutExperience { get; set; }

        //Relationships
        [Display(Name = "Select Athlete(s)")]
        [Required(ErrorMessage = "Athlete(s) is required")]
        public List<int> AthleteIds { get; set; }

        [Display(Name = "Select a Workout Type")]
        [Required(ErrorMessage = "Workout Type is required")]
        public int WorkoutId { get; set; }

        [Display(Name = "Select a Sponsor")]
        [Required(ErrorMessage = "Sponsor is required")]
        public int SponsorId { get; set; }
    }
}
