using Microsoft.EntityFrameworkCore;
using TRPGServer.Models;

namespace TRPGServer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        
    }

}
