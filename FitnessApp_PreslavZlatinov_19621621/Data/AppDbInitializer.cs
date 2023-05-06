using FitnessApp_PreslavZlatinov_19621621.Data.Enums;
using FitnessApp_PreslavZlatinov_19621621.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessApp_PreslavZlatinov_19621621.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //WorkoutType
                if(!context.WorkoutTypes.Any())
                {
                    context.WorkoutTypes.AddRange(new List<WorkoutType>()
                    {
                        new WorkoutType()
                        {
                            Name = "Powerlifting",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/0/05/IPF_World_Champion_Dean_Bowring_performing_the_three_Powerlifting_moves.jpg",
                            Description = "Powerlifting Description"
                        },
                        new WorkoutType()
                        {
                            Name = "Powerbuilding",
                            Logo = "https://fitnessvolt.com/wp-content/uploads/2018/11/Ronnie-Coleman.jpg",
                            Description = "Powerbuilding Description"
                        },
                        new WorkoutType()
                        {
                            Name = "Bodybuilding",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/0/05/Arnold_Schwarzenegger_1974.jpg",
                            Description = "Bodybuilding Description"
                        },
                        new WorkoutType()
                        {
                            Name = "Cardio",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/3/33/Gym_Cardio_Area_Overlooking_Greenery.JPG",
                            Description = "Cardio Description"
                        },
                        new WorkoutType()
                        {
                            Name = "Calisthenics",
                            Logo = "https://www.urbanmovement.info/wp-content/uploads/2021/07/Streetworkout-3.jpg",
                            Description = "Calisthenics Description"
                        },
                    });
                    context.SaveChanges();
                }

                //Athletes
                if (!context.Athletes.Any())
                {
                    context.Athletes.AddRange(new List<Athlete>()
                    {
                        new Athlete()
                        {
                            FullName = "David Laid",
                            ProfilePictureURL = "https://i.pinimg.com/originals/a3/5c/31/a35c31cd55b14b3cbb7dc951dc6dd8cc.jpg",
                            Bio = "David Laid Bio"
                        },
                        new Athlete()
                        {
                            FullName = "Jeff Nippard",
                            ProfilePictureURL = "https://www.greatestphysiques.com/wp-content/uploads/2022/09/201134611_483207166237561_5502985738391641560_n.jpg",
                            Bio = "Jeff Nippard Bio"
                        },
                        new Athlete()
                        {
                            FullName = "Emil Krastev",
                            ProfilePictureURL = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/293329639_457661149698866_8568028763921487792_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=nNukb9vVeXIAX-TIkbO&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBbjTge5fhngZEZqC00dgD3M2W9NbiW_jfLui8ScqGM3g&oe=645782B0",
                            Bio = "Emil Krastev Bio"
                        },
                        new Athlete()
                        {
                            FullName = "Lexx Little",
                            ProfilePictureURL = "https://tikkaykhan.com/wp-content/uploads/2022/10/Lexx-Little-Career-819x1024.jpg",
                            Bio = "Lexx Little Bio"
                        },
                        new Athlete()
                        {
                            FullName = "Chris Heria",
                            ProfilePictureURL = "https://www.ilblast.it/wp/wp-content/uploads/2022/05/image-1-2.jpg",
                            Bio = "Chris Heria Bio"
                        },
                    });
                    context.SaveChanges();
                }

                //Sponsors
                if (!context.Sponsors.Any())
                {
                    context.Sponsors.AddRange(new List<Sponsor>()
                    {
                        new Sponsor()
                        {
                            Name = "Gymshark",
                            Logo = "https://logos-world.net/wp-content/uploads/2022/01/Gymshark-Symbol.png",
                            Description = "Gymshark Description"
                        },
                        new Sponsor()
                        {
                            Name = "Young LA",
                            Logo = "https://pbs.twimg.com/profile_images/1423368674237304835/ufIN39ux_400x400.jpg",
                            Description = "YoungLA Description"
                        },
                        new Sponsor()
                        {
                            Name = "Vanquish",
                            Logo = "https://i.pinimg.com/originals/fc/4d/06/fc4d069335b078eff313c2e1aa5eec2f.png",
                            Description = "Vanquish Description"
                        },
                        new Sponsor()
                        {
                            Name = "MyProtein",
                            Logo = "https://www.myprotein.bg/c-images/fb-image.png",
                            Description = "MyProtein Description"
                        },
                        new Sponsor()
                        {
                            Name = "SBD",
                            Logo = "https://sbd.bh/wp-content/uploads/2019/11/SBD_Logo_Black.png",
                            Description = "SBD Apparel Description"
                        },
                    });
                    context.SaveChanges();
                }

                //Workout
                if (!context.Workouts.Any())
                {
                    context.Workouts.AddRange(new List<Workout>()
                    {
                        new Workout()
                        {
                            Name = "Powerbuilding System",
                            Description = "Powerbuilding System is created by David Laid",
                            Price = 59.99,
                            ImageURL = "https://cdn.shopify.com/s/files/1/0630/1794/3286/products/ThePowerbuildingSystem_grande.png?v=1669860465",
                            Days = 6,
                            Goal = "Strength and Hypertrophy",
                            WorkoutId = 2,
                            SponsorId = 1,
                            WorkoutExperience = WorkoutExperience.Advanced
                        },
                        new Workout()
                        {
                            Name = "The Essentials Program",
                            Description = "The Essentials Program is created by Jeff Nippard",
                            Price = 49.99,
                            ImageURL = "https://cdn.shopify.com/s/files/1/0630/1794/3286/products/TheEssentialsProgram_grande.png?v=1669860475",
                            Days = 5,
                            Goal = "Strength and Hypertrophy",
                            WorkoutId = 2,
                            SponsorId = 5,
                            WorkoutExperience = WorkoutExperience.Intermediate
                        },
                        new Workout()
                        {
                            Name = "Upper Lower",
                            Description = "Upper Lower is created by Jeff Nippard",
                            Price = 39.99,
                            ImageURL = "https://cdn.shopify.com/s/files/1/0630/1794/3286/products/UpperLowerSizeandStrengthProgram_grande.png?v=1669860599",
                            Days = 4,
                            Goal = "Muscle Building",
                            WorkoutId = 3,
                            SponsorId = 5,
                            WorkoutExperience = WorkoutExperience.Advanced
                        },
                        new Workout()
                        {
                            Name = "Push Pull Legs",
                            Description = "Push Pull Legs is created by Jeff Nippard",
                            Price = 39.99,
                            ImageURL = "https://cdn.shopify.com/s/files/1/0630/1794/3286/products/Intermediate-AdvancedPushPullLegsHypertrophyProgram_grande.png?v=1669859625",
                            Days = 5,
                            Goal = "Muscle Building",
                            WorkoutId = 3,
                            SponsorId = 3,
                            WorkoutExperience = WorkoutExperience.Advanced
                        },
                        new Workout()
                        {
                            Name = "Bench Press",
                            Description = "Bench Press is created by Jeff Nippard",
                            Price = 29.99,
                            ImageURL = "https://cdn.shopify.com/s/files/1/0630/1794/3286/products/BenchPressSpecializationProgram_grande.png?v=1669859158",
                            Days = 5,
                            Goal = "Strength",
                            WorkoutId = 1,
                            SponsorId = 5,
                            WorkoutExperience = WorkoutExperience.Athlete
                        },
                        new Workout()
                        {
                            Name = "Squat",
                            Description = "Squat is created by Jeff Nippard",
                            Price = 19.90,
                            ImageURL = "https://cdn.shopify.com/s/files/1/0630/1794/3286/products/10WeekSquatSpecializationProgram_grande.png?v=1669859037",
                            Days = 5,
                            Goal = "Strength",
                            WorkoutId = 1,
                            SponsorId = 5,
                            WorkoutExperience = WorkoutExperience.Advanced
                        }
                    });
                    context.SaveChanges();
                }

                //Athlete and Workout
                if (!context.Athletes_Workouts.Any())
                {
                    context.Athletes_Workouts.AddRange(new List<Athlete_Workout>()
                    {
                        new Athlete_Workout()
                        {
                            AthleteId = 1,
                            WorkoutId = 1
                        },
                        new Athlete_Workout()
                        {
                            AthleteId = 2,
                            WorkoutId = 2
                        },

                         new Athlete_Workout()
                        {
                            AthleteId = 2,
                            WorkoutId = 3
                        },
                         new Athlete_Workout()
                        {
                            AthleteId = 2,
                            WorkoutId = 4
                        },

                         new Athlete_Workout()
                        {
                            AthleteId = 2,
                            WorkoutId = 5
                        },
                         new Athlete_Workout()
                        {
                            AthleteId = 2,
                            WorkoutId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
