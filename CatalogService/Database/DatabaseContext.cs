using Microsoft.EntityFrameworkCore;

namespace CatalogService.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        //checking jenkins pipeline
        public DbSet<Product>? Products { get; set; }
    }
}
