using Microsoft.EntityFrameworkCore;

namespace Student.API
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Stocks> Stocks { get; set; }
    }
}
