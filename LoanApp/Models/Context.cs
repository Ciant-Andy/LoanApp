using Microsoft.EntityFrameworkCore;

namespace LoanApp.Models
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Loan> Loans { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loan>().HasData(
                    new Loan { Id = 1, Name = "Test1" },
                    new Loan { Id = 2, Name = "Test2" },
                    new Loan { Id = 3, Name = "Test3" }
            );
        }
    }
    
}
