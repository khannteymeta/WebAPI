
using AttendenceManagementSystem.Domain.Entity;
using Microsoft.EntityFrameworkCore;
namespace AttendenceManagementSystem.Infrastructure
{
    public class TimeSheetDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }

     

        public string DbPath { get; }

        public TimeSheetDbContext()
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "TimeSheetDB.db");
        }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data source ={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //set primary key
            modelBuilder.Entity<UserAccount>().HasKey(p => p.UserAccountID);

            //set auto primary key
            modelBuilder.Entity<UserAccount>().Property(f => f.UserAccountID).ValueGeneratedOnAdd();

            //configure one to one relation
            modelBuilder.Entity<Employee>()
                .HasOne<UserAccount>(u => u.UserAccount)
                .WithOne(e => e.Employee)
                .HasForeignKey<UserAccount>(u => u.UserAccountOfEmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            //cofigure one to many relation
            modelBuilder.Entity<Employee>()
                .HasMany<Log>(l => l.Logs)
                .WithOne(e => e.Employee)
                .HasForeignKey(l => l.CurrentEmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
