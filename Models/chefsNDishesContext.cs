using Microsoft.EntityFrameworkCore;

namespace cd_c_chefsNDishes.Models
{
    public class chefsNDishesContext : DbContext
    {
        public chefsNDishesContext(DbContextOptions options) : base(options) { }
        public DbSet<Dish> Dishes {get;set;}
        public DbSet<Chef> Chefs {get;set;}

    }
}