using Microsoft.EntityFrameworkCore;

namespace SumOfArguments.ConsoleApp.DB
{
    public class SumOfArgumentsContext : DbContext
    {
        public DbSet<Sums> Sums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SumOfArguments.db;Password=HelloThere!;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sums>().HasKey(s => s.Id);
        }
    }
}
