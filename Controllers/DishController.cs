using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class DishController : Controller
    {   
        private MyContext dbContext;

        public DishController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public ViewResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes.ToList();
            return View("Index", AllDishes);
        }

        [HttpGet("new")]
        public ViewResult New()
        {
            return View("NewDish");
        }

        [HttpPost("dish/create")]
        public IActionResult Create(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NewDish");
            }
        }

        [HttpGet("{dishId}")]
        public ViewResult Details(int dishId)
        {
            Dish specDish = dbContext.Dishes.SingleOrDefault(dish => dish.DishId == dishId);
            return View("Details", specDish);
        }

        [HttpGet("edit/{dishId}")]
        public ViewResult Edit(int dishId)
        {
            Dish specDish = dbContext.Dishes.SingleOrDefault(dish => dish.DishId == dishId);
            return View("Edit", specDish);
        }

        [HttpPost("edit/{dishId}")]
        public IActionResult Update(int dishId, Dish updatedDish)
        {
            if(ModelState.IsValid)
            {
                Dish specDish = dbContext.Dishes.SingleOrDefault(dish => dish.DishId == dishId);
                specDish.Name = updatedDish.Name;
                specDish.Chef = updatedDish.Chef;
                specDish.Calories = updatedDish.Calories;
                specDish.Tastiness = updatedDish.Tastiness;
                specDish.Description = updatedDish.Description;
                specDish.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("Details", dishId);
            }
            else
            {
                return View("Edit", updatedDish);
            }
        }

        [HttpGet("dish/delete/{dishId}")]
        public RedirectToActionResult Delete(int dishId)
        {
            Dish specDish = dbContext.Dishes.SingleOrDefault(dish => dish.DishId == dishId);
            dbContext.Dishes.Remove(specDish);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
