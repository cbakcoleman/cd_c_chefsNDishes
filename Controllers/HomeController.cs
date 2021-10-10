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
        private DishContext _dish_context;
        private ChefContext _chef_context;

        public HomeController(DishContext context)
        {
            _dish_context = context;
        }
        public HomeController(ChefContext context)
        {
            _chef_context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}