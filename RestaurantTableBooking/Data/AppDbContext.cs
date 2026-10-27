using Microsoft.EntityFrameworkCore;
using RestaurantTableBooking.Entities; 

namespace RestaurantTableBooking.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Table> Tables { get; set; }
}