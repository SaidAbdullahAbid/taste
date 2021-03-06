using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Taste.Models;

namespace Taste.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<FoodType> FoodType { get; set; }
        public DbSet<MenuItem> MeunItem { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
