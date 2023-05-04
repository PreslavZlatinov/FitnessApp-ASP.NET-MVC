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
                            Description = "Powerlifting is a strength sport that consists of three attempts at maximal weight on three lifts: squat, bench press, and deadlift."
                        },
                        new WorkoutType()
                        {
                            Name = "Powerbuilding",
                            Logo = "https://fitnessvolt.com/wp-content/uploads/2018/11/Ronnie-Coleman.jpg",
                            Description = "Powerbuilding is a combination of two different training styles: powerlifting and bodybuilding. It uses three specific exercises — the deadlift, bench press and squat — to help you build strength, lift heavier and increase muscle mass."
                        },
                        new WorkoutType()
                        {
                            Name = "Bodybuilding",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/0/05/Arnold_Schwarzenegger_1974.jpg",
                            Description = "Bodybuilding is the use of progressive resistance exercise to control and develop one's muscles (muscle building) by muscle hypertrophy for aesthetic purposes."
                        },
                        new WorkoutType()
                        {
                            Name = "Cardio",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/3/33/Gym_Cardio_Area_Overlooking_Greenery.JPG",
                            Description = "Cardio is a type of exercise that gets your heart rate up and keeps it up for a prolonged period of time. Your respiratory system will start working harder as you begin to breathe faster and more deeply."
                        },
                        new WorkoutType()
                        {
                            Name = "Street Workout",
                            Logo = "https://www.urbanmovement.info/wp-content/uploads/2021/07/Streetworkout-3.jpg",
                            Description = "Street workouts are a physical activity performed in outdoor parks or public facilities. Street workouts are divided into two main branches, strength training and dynamics."
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
                            Bio = "David Laid is an Estonian-American bodybuilder, fitness model and social media personality who is primarily known for his transformation videos on YouTube. Riding on his social media popularity, he later became a Gymshark sponsored athlete."
                        },
                        new Athlete()
                        {
                            FullName = "Jeff Nippard",
                            ProfilePictureURL = "https://www.greatestphysiques.com/wp-content/uploads/2022/09/201134611_483207166237561_5502985738391641560_n.jpg",
                            Bio = "Professional bodybuilder and coach who uses social media to vlog his experiences training and share informative videos on bodybuilding."
                        },
                        new Athlete()
                        {
                            FullName = "Emil Krastev",
                            ProfilePictureURL = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/293329639_457661149698866_8568028763921487792_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=nNukb9vVeXIAX-TIkbO&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBbjTge5fhngZEZqC00dgD3M2W9NbiW_jfLui8ScqGM3g&oe=645782B0",
                            Bio = "Emil is a multiple champion in the republican competitions. In 2019, Emil Krastev received a record for lifting from a bench press in the category up to 93 kg for juniors up to 23 years old. The new achievement was recorded from the third attempt - 203.5 kg."
                        },
                        new Athlete()
                        {
                            FullName = "Lexx Little",
                            ProfilePictureURL = "https://tikkaykhan.com/wp-content/uploads/2022/10/Lexx-Little-Career-819x1024.jpg",
                            Bio = "Bodybuilder and fitness model who is known for being a Young LA athlete. He shares his fitness and workout-related content through Instagram. He occasionally posts lifestyle content featuring his house and cars."
                        },
                        new Athlete()
                        {
                            FullName = "Chris Heria",
                            ProfilePictureURL = "https://www.ilblast.it/wp/wp-content/uploads/2022/05/image-1-2.jpg",
                            Bio = "Chris Heria (born December 21, 1991) is the Founder and Chief Executive Officer of ThenX fitness program which involves a workout routine with weights and calisthenics."
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
                            Description = "Gymshark is a British fitness apparel and accessories manufacturer and retailer headquartered in Solihull, England."
                        },
                        new Sponsor()
                        {
                            Name = "Young LA",
                            Logo = "https://pbs.twimg.com/profile_images/1423368674237304835/ufIN39ux_400x400.jpg",
                            Description = "YoungLA is a lifestyle clothing brand headquartered in Los Angeles, CA."
                        },
                        new Sponsor()
                        {
                            Name = "Vanquish",
                            Logo = "https://i.pinimg.com/originals/fc/4d/06/fc4d069335b078eff313c2e1aa5eec2f.png",
                            Description = "Vanquish Fitness is an apparel brand and online retailer, based in London."
                        },
                        new Sponsor()
                        {
                            Name = "MyProtein",
                            Logo = "https://www.myprotein.bg/c-images/fb-image.png",
                            Description = "Myprotein is a British bodybuilding supplement brand which has developed into a family of brands, including Myvitamins, Myvegan, MyPRO and MP Activewear."
                        },
                        new Sponsor()
                        {
                            Name = "SBD",
                            Logo = "https://sbd.bh/wp-content/uploads/2019/11/SBD_Logo_Black.png",
                            Description = "SBD Apparel is a world leading strength and fitness brand."
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
                            Name = "DUP Program",
                            Description = "DUP Program is created by David Laid",
                            Price = 59.99,
                            ImageURL = "https://fitnessvolt.com/wp-content/uploads/2018/06/David-Laid-2.jpg",
                            Days = 6,
                            Goal = "Strength and Hypertrophy",
                            WorkoutId = 2,
                            SponsorId = 1,
                            WorkoutExperience = WorkoutExperience.Advanced
                        },
                        new Workout()
                        {
                            Name = "Powerbuilding System",
                            Description = "Powerbuilding System is created by Jeff Nippard",
                            Price = 49.99,
                            ImageURL = "https://cdn.shopify.com/s/files/1/0630/1794/3286/products/ThePowerbuildingSystem_grande.png?v=1669860465",
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
                            Name = "Powerlifting Program",
                            Description = "Squat, Bench and Deadlift",
                            Price = 66.60,
                            ImageURL = "https://sportsmatik.com/uploads/matik-sports-corner/matik-know-how/powerlifting_1564640075.jpg",
                            Days = 5,
                            Goal = "Strength",
                            WorkoutId = 1,
                            SponsorId = 5,
                            WorkoutExperience = WorkoutExperience.Athlete
                        },
                        new Workout()
                        {
                            Name = "Calisthenics Training",
                            Description = "Calisthenics Training made by Chris Heria",
                            Price = 39.50,
                            ImageURL = "https://i1.sndcdn.com/artworks-000627876727-6bj6xd-t500x500.jpg",
                            Days = 5,
                            Goal = "Hypertrophy and Endurance",
                            WorkoutId = 5,
                            SponsorId = 4,
                            WorkoutExperience = WorkoutExperience.Beginner
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
                            AthleteId = 3,
                            WorkoutId = 5
                        },
                         new Athlete_Workout()
                        {
                            AthleteId = 5,
                            WorkoutId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
