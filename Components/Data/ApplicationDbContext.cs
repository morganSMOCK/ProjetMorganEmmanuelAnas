using BlazorApp1.Components.Data;
using BlazorApp1.Components.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Boats> Bateaux { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
}