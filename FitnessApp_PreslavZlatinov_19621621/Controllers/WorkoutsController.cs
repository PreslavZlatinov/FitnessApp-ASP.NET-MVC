﻿using FitnessApp_PreslavZlatinov_19621621.Data;
using FitnessApp_PreslavZlatinov_19621621.Data.Services;
using FitnessApp_PreslavZlatinov_19621621.Data.Static;
using FitnessApp_PreslavZlatinov_19621621.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace FitnessApp_PreslavZlatinov_19621621.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class WorkoutsController : Controller
    {

        private readonly IWorkoutsService _service;

        public WorkoutsController(IWorkoutsService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allWorkouts = await _service.GetAllAsync(n => n.WorkoutType);
            return View(allWorkouts);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var allWorkouts = await _service.GetAllAsync(n => n.WorkoutType);

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = allWorkouts.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) || 
                n.Description.ToLower().Contains(searchString.ToLower()) || 
                n.Gender.ToString().ToLower().Contains(searchString.ToLower()) || 
                n.WorkoutExperience.ToString().ToLower().Contains(searchString.ToLower())).ToList();

                return View("Index", filteredResult);
            }

            return View("Index", allWorkouts);
        }

        //GET: Workouts/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var workoutDetail = await _service.GetWorkoutByIdAsync(id);
            return View(workoutDetail);
        }

        //GET: Workouts/Create

        public async Task<IActionResult> Create()
        {
            var workoutDropdownsData = await _service.GetNewWorkoutDropdownsValues();

            ViewBag.WorkoutId = new SelectList(workoutDropdownsData.WorkoutTypes, "Id", "Name");
            ViewBag.SponsorId = new SelectList(workoutDropdownsData.Sponsors, "Id", "Name");
            ViewBag.AthleteIds = new SelectList(workoutDropdownsData.Athletes, "Id", "FullName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewWorkoutVM workout)
        {
            if (!ModelState.IsValid)
            {
                var workoutDropdownsData = await _service.GetNewWorkoutDropdownsValues();

                ViewBag.WorkoutId = new SelectList(workoutDropdownsData.WorkoutTypes, "Id", "Name");
                ViewBag.SponsorId = new SelectList(workoutDropdownsData.Sponsors, "Id", "Name");
                ViewBag.AthleteIds = new SelectList(workoutDropdownsData.Athletes, "Id", "FullName");

                return View(workout);
            }
            await _service.AddNewWorkoutAsync(workout);
            return RedirectToAction(nameof(Index));
        }

        //GET: Workouts/Edit/1

        public async Task<IActionResult> Edit(int id)
        {

            var workoutDetails = await _service.GetWorkoutByIdAsync(id);
            if(workoutDetails == null) return View("NotFound");

            var response = new NewWorkoutVM()
            {
                Id = workoutDetails.Id,
                Name = workoutDetails.Name,
                Description = workoutDetails.Description,
                Price = workoutDetails.Price,
                ImageURL = workoutDetails.ImageURL,
                Gender = workoutDetails.Gender,
                Days = workoutDetails.Days,
                Goal = workoutDetails.Goal,
                Equipment = workoutDetails.Equipment,
                WorkoutExperience = workoutDetails.WorkoutExperience,
                WorkoutId = workoutDetails.WorkoutId,
                SponsorId = workoutDetails.SponsorId,
                AthleteIds = workoutDetails.Athletes_Workouts.Select(n => n.AthleteId).ToList(),
            };

            var workoutDropdownsData = await _service.GetNewWorkoutDropdownsValues();

            ViewBag.WorkoutId = new SelectList(workoutDropdownsData.WorkoutTypes, "Id", "Name");
            ViewBag.SponsorId = new SelectList(workoutDropdownsData.Sponsors, "Id", "Name");
            ViewBag.AthleteIds = new SelectList(workoutDropdownsData.Athletes, "Id", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewWorkoutVM workout)
        {
            if (id != workout.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var workoutDropdownsData = await _service.GetNewWorkoutDropdownsValues();

                ViewBag.WorkoutId = new SelectList(workoutDropdownsData.WorkoutTypes, "Id", "Name");
                ViewBag.SponsorId = new SelectList(workoutDropdownsData.Sponsors, "Id", "Name");
                ViewBag.AthleteIds = new SelectList(workoutDropdownsData.Athletes, "Id", "FullName");

                return View(workout);
            }
            await _service.UpdateWorkoutAsync(workout);
            return RedirectToAction(nameof(Index));
        }
    }
}
