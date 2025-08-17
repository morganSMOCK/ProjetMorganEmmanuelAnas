using BlazorApp1.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Components.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Boat> Boats { get; set; }
    }
}