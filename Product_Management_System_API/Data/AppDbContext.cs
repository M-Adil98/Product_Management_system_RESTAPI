using Microsoft.EntityFrameworkCore;
using Product_Management_System_API.Models;

namespace Product_Management_System_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}