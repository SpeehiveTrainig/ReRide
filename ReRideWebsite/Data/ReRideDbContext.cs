
using Microsoft.EntityFrameworkCore;
using ReRideWebsite.Models;

public class ReRideDbContext : DbContext
{
    public ReRideDbContext(DbContextOptions<ReRideDbContext> options) : base(options)
    {
    }
    public DbSet<Car> Cars { get; set; }

}