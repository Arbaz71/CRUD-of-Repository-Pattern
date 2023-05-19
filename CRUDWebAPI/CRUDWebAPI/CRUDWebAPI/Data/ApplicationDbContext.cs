using CRUDWebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUDWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {

        }
        public DbSet<Product> Products { get; set; }

    }
}

