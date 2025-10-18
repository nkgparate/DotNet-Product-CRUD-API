
using Microsoft.EntityFrameworkCore;
using ProductCRUDAPI.Models;

namespace ProductCRUDAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}