namespace Diphda.Infrastructure
{
    using Microsoft.EntityFrameworkCore;
    using Diphda.Infrastructure.Mappings;
    using Diphda.Domain.Account;
    
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
        }
    }
}