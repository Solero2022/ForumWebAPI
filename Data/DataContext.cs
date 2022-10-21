using Microsoft.EntityFrameworkCore;
using ForumWebAPI.Models;
using Thread = ForumWebAPI.Models.Thread;

namespace ForumWebAPI.Data
{
    public class DataContext : DbContext
    {

        
        public DataContext(DbContextOptions<DataContext> options) : base(options) {

        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Thread> Threads { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().ToTable("Posts");
            modelBuilder.Entity<Thread>().ToTable("Threads");
        }

    }
}
