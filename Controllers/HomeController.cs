using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using cd_c_chefsNDishes.Models;

namespace cd_c_chefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private chefsNDishesContext _context;

        public HomeController(chefsNDishesContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Chefs()
        {
            ViewBag.AllChefs = _context.Chefs.
                Include(c => c.CreatedDishes).
                OrderByDescending(c => c.LastName).ToList();

            return View("Chefs");
        }

        [HttpGet("chef/add")]
        public IActionResult AddChef()
        {
            return View("AddChef");
        }

        [HttpPost("thischef/add")]
        public IActionResult ThisChefAdd(Chef chef)
        {
            if(ModelState.IsValid)
            {
                if(chef.BirthDate < DateTime.Now.AddYears(-18))
                {
                    ModelState.AddModelError("BirthDate", "Chef must be 18 yrs or older.");
                }
                _context.Add(chef);
                _context.SaveChanges();
                return RedirectToAction("Chefs");
            }
            else
            {
                return View("addchef", chef);
            }
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            
            ViewBag.AllDishes = _context.Dishes.
                Include(d => d.Creator).
                OrderByDescending(d => d.CreatedAt).ToList();
            

            return View("Dishes");
        }

        [HttpGet("dish/add")]
        public IActionResult AddDish()
        {
            ViewBag.AllChefs = _context.Chefs.
                OrderByDescending(c => c.LastName).ToList();
            return View("AddDish");
        }

        [HttpPost("thisdish/add")]
        public IActionResult ThisDishAdd(Dish dish)
        {
            if(ModelState.IsValid)
            {
                System.Console.WriteLine("Model state was valid");
                _context.Add(dish);
                _context.SaveChanges();
                return RedirectToAction("dishes");
            }
            else
            {
                ViewBag.AllChefs = _context.Chefs.
                OrderByDescending(c => c.LastName).ToList();
                return View("AddDish");
            }
        }

    }
}