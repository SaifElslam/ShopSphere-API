using Microsoft.EntityFrameworkCore;
using ShopSphere_API.Models;
namespace ShopSphere_API.Data
{
    public class AppDbContext : DbContext
    {

     public AppDbContext(DbContextOptions<AppDbContext> options ): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CarItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public object Produ { get; internal set; }
    }
}
