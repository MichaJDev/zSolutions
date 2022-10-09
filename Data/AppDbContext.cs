using Microsoft.EntityFrameworkCore;
using zSolutions.Models.Users;
using zSolutions.Models.Jobs;
using zSolutions.Models.Contact;
namespace zSolutions.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Contact> Contact { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(c => c.Jobs)
                .WithOne(e => e.Client);
        }
    }
}
