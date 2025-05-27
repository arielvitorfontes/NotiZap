using Back.Models;
using Microsoft.EntityFrameworkCore;

namespace Back.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Alert> Alerts => Set<Alert>();
    public DbSet<Recipient> Recipients => Set<Recipient>();
    public DbSet<User> Users => Set<User>();
}