using FitnessApp_PreslavZlatinov_19621621.Data.Enums;
using FitnessApp_PreslavZlatinov_19621621.Data.Static;
using FitnessApp_PreslavZlatinov_19621621.Models;
using Microsoft.AspNetCore.Identity;
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
                            Logo = "https://musclepit.com.au/wp-content/uploads/2021/08/powerlifting-4.jpg",
                            Description = "Powerlifting Description"
                        },
                        new WorkoutType()
                        {
                            Name = "Powerbuilding",
                            Logo = "https://musclepit.com.au/wp-content/uploads/2021/08/powerlifting-3.jpg",
                            Description = "Powerbuilding Description"
                        },
                        new WorkoutType()
                        {
                            Name = "Bodybuilding",
                            Logo = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/306913732_448251797409596_7648187554695807179_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=ZmiyrFAkHgIAX-BPLAF&_nc_ht=scontent.fsof10-1.fna&oh=00_AfC888ge0s3MpSvDkaL8KgpYkVaJShmWo918iQL_Wxvc9w&oe=646F8F64",
                            Description = "Bodybuilding Description"
                        },
                        new WorkoutType()
                        {
                            Name = "Cardio",
                            Logo = "https://gymkituk.com/media/magefan_blog/f2d5ea372f327df50a8d100b03b497ac_1_1_.jpg",
                            Description = "Cardio Description"
                        },
                        new WorkoutType()
                        {
                            Name = "Calisthenics",
                            Logo = "https://i.pinimg.com/originals/1e/7b/9f/1e7b9f2f455f25892ee7bcb809477a4a.jpg",
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
                            ProfilePictureURL = "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.6435-9/57572811_383221482519101_6746941306125156352_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=9267fe&_nc_ohc=LsPBgub06YMAX8mfN5o&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAThi-QnLYfeMjg7b08IJ8Mu16wwnbrRr1j3JAEAZRpBw&oe=6491AC53",
                            Bio = "David Laid Bio"
                        },
                        new Athlete()
                        {
                            FullName = "Jeff Nippard",
                            ProfilePictureURL = "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/311883472_669714404513712_6051454543349360057_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=b984Ig9ZZs8AX_ArMLB&_nc_oc=AQmQ4sl9uaIrCU9IITIE2G7vAJwb6X09o1wPpzdt8BupPM7K6VTuvixZ27y2PdKSHok&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDpZBqNWGWgu4ugBe1SwToQa2jU0yy3OUQh6jBIRAONbg&oe=646EAD74",
                            Bio = "Jeff Nippard Bio"
                        },
                        new Athlete()
                        {
                            FullName = "Emil Krastev",
                            ProfilePictureURL = "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.6435-9/49948677_2276902545918951_3462954013899620352_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=9267fe&_nc_ohc=8izqX_Wj3dMAX_ALaMg&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBRSdm0TdWm7Nzt04SAmCzWnkLeKxAkSYNDACmZuRC8Tw&oe=64919EB1",
                            Bio = "Emil Krastev Bio"
                        },
                        new Athlete()
                        {
                            FullName = "Lexx Little",
                            ProfilePictureURL = "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.6435-9/155056000_976904423129037_7131058702266364751_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=a26aad&_nc_ohc=KGVbSdMLgVwAX9dTFSS&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAUxXmc1SRFOykHgvcPH6BP9gAOCA2a8y8lSovhspQcqA&oe=64919CEA",
                            Bio = "Lexx Little Bio"
                        },
                        new Athlete()
                        {
                            FullName = "Chris Heria",
                            ProfilePictureURL = "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.6435-9/131132465_3984095238321506_1689892389001539737_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=a26aad&_nc_ohc=yJkgxaCvsdYAX-S2BgX&_nc_ht=scontent.fsof10-1.fna&oh=00_AfCFeIXh-b3k2ORaKa1TCqgwdDr4rOxey5nZ2Kigp3wPXQ&oe=6491B4D6",
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
                            Logo = "https://cdn.shopify.com/s/files/1/0156/6146/files/gymshark_social_banner_1200x1200.jpg?v=1613146426",
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
                            Gender = Gender.Male,
                            Days = 6,
                            Goal = "Strength and Hypertrophy",
                            WorkoutId = 2,
                            SponsorId = 1,
                            Equipment = "Barbell, Dumbbells, Squat Rack, Weights",
                            WorkoutExperience = WorkoutExperience.Advanced
                        },
                        new Workout()
                        {
                            Name = "The Essentials Program",
                            Description = "The Essentials Program is created by Jeff Nippard",
                            Price = 49.99,
                            ImageURL = "https://cdn.shopify.com/s/files/1/0630/1794/3286/products/TheEssentialsProgram_grande.png?v=1669860475",
                            Gender = Gender.Male,
                            Days = 5,
                            Goal = "Strength and Hypertrophy",
                            WorkoutId = 2,
                            SponsorId = 5,
                            Equipment = "Barbell, Dumbbells, Squat Rack, Weights",
                            WorkoutExperience = WorkoutExperience.Intermediate
                        },
                        new Workout()
                        {
                            Name = "Upper Lower",
                            Description = "Upper Lower is created by Jeff Nippard",
                            Price = 39.99,
                            ImageURL = "https://cdn.shopify.com/s/files/1/0630/1794/3286/products/UpperLowerSizeandStrengthProgram_grande.png?v=1669860599",
                            Gender = Gender.Male,
                            Days = 4,
                            Goal = "Muscle Building",
                            WorkoutId = 3,
                            SponsorId = 5,
                            Equipment = "Barbell, Dumbbells, Squat Rack, Weights",
                            WorkoutExperience = WorkoutExperience.Advanced
                        },
                        new Workout()
                        {
                            Name = "Push Pull Legs",
                            Description = "Push Pull Legs is created by Jeff Nippard",
                            Price = 39.99,
                            ImageURL = "https://cdn.shopify.com/s/files/1/0630/1794/3286/products/Intermediate-AdvancedPushPullLegsHypertrophyProgram_grande.png?v=1669859625",
                            Gender = Gender.Male,
                            Days = 5,
                            Goal = "Muscle Building",
                            WorkoutId = 3,
                            SponsorId = 3,
                            Equipment = "Barbell, Dumbbells, Squat Rack, Weights",
                            WorkoutExperience = WorkoutExperience.Advanced
                        },
                        new Workout()
                        {
                            Name = "Bench Press",
                            Description = "Bench Press is created by Jeff Nippard",
                            Price = 29.99,
                            ImageURL = "https://cdn.shopify.com/s/files/1/0630/1794/3286/products/BenchPressSpecializationProgram_grande.png?v=1669859158",
                            Gender = Gender.Male,
                            Days = 5,
                            Goal = "Strength",
                            WorkoutId = 1,
                            SponsorId = 5,
                            Equipment = "Barbell, Weights",
                            WorkoutExperience = WorkoutExperience.Athlete
                        },
                        new Workout()
                        {
                            Name = "Squat",
                            Description = "Squat is created by Jeff Nippard",
                            Price = 19.90,
                            ImageURL = "https://cdn.shopify.com/s/files/1/0630/1794/3286/products/10WeekSquatSpecializationProgram_grande.png?v=1669859037",
                            Gender = Gender.Male,
                            Days = 5,
                            Goal = "Strength",
                            WorkoutId = 1,
                            SponsorId = 5,
                            Equipment = "Barbell, Squat Rack, Weights",
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

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@fitness.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@fitness.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
