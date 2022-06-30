



using Microsoft.EntityFrameworkCore;
using RazorCrashDummy.Models;

namespace RazorCrashDummy.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Shift> Shift { get; set; }
    }
}
