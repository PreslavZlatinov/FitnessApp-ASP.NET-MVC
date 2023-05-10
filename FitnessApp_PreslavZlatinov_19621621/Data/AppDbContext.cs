using FitnessApp_PreslavZlatinov_19621621.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessApp_PreslavZlatinov_19621621.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Athlete_Workout>().HasKey(aw => new
            {
                aw.AthleteId,
                aw.WorkoutId
            });

            modelBuilder.Entity<Athlete_Workout>().HasOne(w => w.Workout).WithMany(aw => aw.Athletes_Workouts).HasForeignKey(w => w.WorkoutId);

            modelBuilder.Entity<Athlete_Workout>().HasOne(w => w.Athlete).WithMany(aw => aw.Athletes_Workouts).HasForeignKey(w => w.AthleteId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Athlete_Workout> Athletes_Workouts { get; set; }
        public DbSet<WorkoutType> WorkoutTypes { get; set; }

        public DbSet<Sponsor> Sponsors { get; set; }

        //Orders related tables
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
