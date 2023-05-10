using FitnessApp_PreslavZlatinov_19621621.Data.Base;
using FitnessApp_PreslavZlatinov_19621621.Data.ViewModels;
using FitnessApp_PreslavZlatinov_19621621.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp_PreslavZlatinov_19621621.Data.Services
{
    public class WorkoutsService:EntityBaseRepository<Workout>, IWorkoutsService
    {

        private readonly AppDbContext _context;
        public WorkoutsService(AppDbContext context):base(context)
        {
            _context = context;
        }

        public async Task AddNewWorkoutAsync(NewWorkoutVM data)
        {
            var newWorkout = new Workout()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageURL = data.ImageURL,
                Days = data.Days,
                Goal = data.Goal,
                WorkoutExperience = data.WorkoutExperience,
                WorkoutId = data.WorkoutId,
                SponsorId = data.SponsorId
            };

            await _context.Workouts.AddAsync(newWorkout);
            await _context.SaveChangesAsync();

            //Add Workoute Athletes
            foreach (var athleteId in data.AthleteIds)
            {
                var newAthleteWorkout = new Athlete_Workout()
                {
                    WorkoutId = newWorkout.Id,
                    AthleteId = athleteId
                };
                await _context.Athletes_Workouts.AddAsync(newAthleteWorkout);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<NewWorkoutDropdownsVM> GetNewWorkoutDropdownsValues()
        {
            var response = new NewWorkoutDropdownsVM()
            {
                Athletes = await _context.Athletes.OrderBy(n => n.FullName).ToListAsync(),
                WorkoutTypes = await _context.WorkoutTypes.OrderBy(n => n.Name).ToListAsync(),
                Sponsors = await _context.Sponsors.OrderBy(n => n.Name).ToListAsync()
            };
            
            return response;
        }

        public async Task<Workout> GetWorkoutByIdAsync(int id)
        {
            var workoutDetails = await _context.Workouts.Include(wt => wt.WorkoutType)
                .Include(s => s.Sponsor)
                .Include(aw => aw.Athletes_Workouts).ThenInclude(a => a.Athlete)
                .FirstOrDefaultAsync(n => n.Id == id);

            return workoutDetails;
        }

        public async Task UpdateWorkoutAsync(NewWorkoutVM data)
        {
            var dbWorkout = await _context.Workouts.FirstOrDefaultAsync(n => n.Id == data.Id);

            if(dbWorkout != null)
            {
                dbWorkout.Name = data.Name;
                dbWorkout.Description = data.Description;
                dbWorkout.Price = data.Price;
                dbWorkout.ImageURL = data.ImageURL;
                dbWorkout.Days = data.Days;
                dbWorkout.Goal = data.Goal;
                dbWorkout.WorkoutExperience = data.WorkoutExperience;
                dbWorkout.WorkoutId = data.WorkoutId;
                dbWorkout.SponsorId = data.SponsorId;

                await _context.SaveChangesAsync();
            }

            //Remove existing athletes
            var existingAthletesDb = _context.Athletes_Workouts.Where(n => n.WorkoutId == data.Id).ToList();
            _context.Athletes_Workouts.RemoveRange(existingAthletesDb);
            await _context.SaveChangesAsync();

            //Add Workoute Athletes
            foreach (var athleteId in data.AthleteIds)
            {
                var newAthleteWorkout = new Athlete_Workout()
                {
                    WorkoutId = data.Id,
                    AthleteId = athleteId
                };
                await _context.Athletes_Workouts.AddAsync(newAthleteWorkout);
            }
            await _context.SaveChangesAsync();
        }
    }
}
