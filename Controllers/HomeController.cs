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
        public IActionResult Index()
        {
            return View();
        }
    }
}