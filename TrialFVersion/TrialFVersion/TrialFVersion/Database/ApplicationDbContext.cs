using Microsoft.EntityFrameworkCore;
using TrialFVersion.Model;

namespace TrialFVersion.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Aliaser> Aliases { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
