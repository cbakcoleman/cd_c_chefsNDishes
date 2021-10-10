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
                OrderByDescending(c => c.CreatedAt).ToList();

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
                _context.Add(chef);
                _context.SaveChanges();
                return View("Chefs");
            }
            else
            {
                return View("addchef", chef);
            }
        }
    }
}