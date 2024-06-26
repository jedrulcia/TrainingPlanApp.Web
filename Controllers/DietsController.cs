﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrainingPlanApp.Web.Constants;
using TrainingPlanApp.Web.Contracts;
using TrainingPlanApp.Web.Data;
using TrainingPlanApp.Web.Models;
using TrainingPlanApp.Web.Repositories;

namespace TrainingPlanApp.Web.Controllers
{
    public class DietsController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IDietRepository dietRepository;
		private readonly IMealRepository mealRepository;
		private readonly IMapper mapper;

        public DietsController(ApplicationDbContext context, IDietRepository dietRepository, IMealRepository mealRepository, IMapper mapper)
        {
            this.context = context;
            this.dietRepository = dietRepository;
			this.mealRepository = mealRepository;
			this.mapper = mapper;
        }

        // GET: Diets
        public async Task<IActionResult> Index()
        {
            var dietsVM = mapper.Map<List<DietVM>>(await dietRepository.GetAllAsync());            
            return View(dietsVM);
        }

        // GET: Diets/Details
        public async Task<IActionResult> Details(int? id)
		{
			var diet = (await dietRepository.GetAsync(id));
			if (diet == null)
            {
                return NotFound();
			}
			var dietVM = mapper.Map<DietVM>(diet);
            return View(dietVM);
		}
        public async Task<IActionResult> MealDetails(int? mealId, int? dietId)
		{
			var meal = await mealRepository.GetAsync(mealId);
			if (meal == null)
			{
				return NotFound();
			}
            var mealVM = mapper.Map<DietMealVM>(meal);
            mealVM.DietId = dietId;
            return View(mealVM);
		}

		// GET: Diets/Create
		public IActionResult Create(string? userId)
		{
			var model = new DietCreateVM
			{
				Meals = new SelectList(context.Meals.OrderBy(e => e.Name), "Id", "Name"),
				UserId = userId
			};
			return View(model);
		}

        // POST: Diets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DietCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await dietRepository.CreateDiet(model);
                    return RedirectToAction(nameof(Index), new { id = model.UserId });
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error has occurred. Please try again later");
            }
            model.Meals = new SelectList(context.Meals, "Id", "Name");
            return View(model);
        }

        [Authorize(Roles = Roles.Administrator)]
        public async Task<IActionResult> ChangeStatus(int id, bool status, string userId)
        {
            await dietRepository.ChangeDietStatus(id, status);
            /*            if (userId == null)
                        {
                            return RedirectToAction(nameof(IndexAdmin));
                        }
                        return RedirectToAction(nameof(Index), new { id = userId });*/
            return RedirectToAction(nameof(Index));
        }
        // GET: Diets/Edit
        public async Task<IActionResult> Edit(int? id, bool redirectToAdmin)
        {
            if (id == null)
            {
                return NotFound();
            }
            var diet = await context.Diets.FindAsync(id);
            if (diet == null)
            {
                return NotFound();
            }
            var dietCreateVM = mapper.Map<DietCreateVM>(diet);
            dietCreateVM.RedirectToAdmin = redirectToAdmin;
            dietCreateVM.Meals = new SelectList(context.Meals, "Id", "Name");
            return View(dietCreateVM);
        }

        // POST: Diets/Edit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DietCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dietRepository.UpdateDiet(model);
                    return RedirectToAction(nameof(Index));
                    /*return RedirectToAction(nameof(Index), new { id = model.UserId });*/
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error has occurred. Please try again later");
            }

            model.Meals = new SelectList(context.Meals, "Id", "Name");
            return View(model);
        }

        // POST: Diets/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await dietRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
