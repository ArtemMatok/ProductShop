using Microsoft.EntityFrameworkCore;
using ProductShop.Models;

namespace ProductShop.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
