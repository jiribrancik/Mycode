using Microsoft.EntityFrameworkCore;
using Reddit2.Model;

namespace Reddit2.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().HasMany(u => u.UserVotes).WithOne(v => v.User).OnDelete(DeleteBehavior.NoAction);
            //modelBuilder.Entity<Post>().HasMany(p => p.Score).WithOne(v => v.Post).OnDelete(DeleteBehavior.NoAction);
            //modelBuilder.Entity<User>().HasMany(u => u.Posts).WithOne(uint =>);
        }
    }
}
