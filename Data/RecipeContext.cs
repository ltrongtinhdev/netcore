using BankWebApi.Models;
using Microsoft.EntityFrameworkCore;
namespace BankWebApi.Data {
    public class RecipeContext: DbContext   {
        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseSqlServer(@"Data Source=C:blog.db");
    }
}