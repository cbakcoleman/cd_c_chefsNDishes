using Microsoft.EntityFrameworkCore;

namespace cd_c_chefsNDishes.Models
{
    public class ChefContext :DbContext
    {
        public ChefContext(DbContextOptions options) : base(options) { }
        public DbSet<Chef> Chefs {get;set;}
    }
}