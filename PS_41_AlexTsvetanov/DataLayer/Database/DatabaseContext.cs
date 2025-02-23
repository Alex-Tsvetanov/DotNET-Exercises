using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using Welcome.Others;

namespace DataLayer.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<DatabaseUser> Users { get; set; }
        public DbSet<DBLogger.LogMessage> Logs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databasePath = @"C:\Users\alext\source\repos\DotNET Exercises\PS_41_AlexTsvetanov\DataLayer\bin\Debug\net8.0\Welcome.db";
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatabaseUser>().Property(e => e.Uid).ValueGeneratedOnAdd();
            modelBuilder.Entity<DBLogger.LogMessage>().Property(e => e.Id).ValueGeneratedOnAdd();

            // Create a user
            var admin = new DatabaseUser()
            {
                Uid = 1,
                Id = 1,
                Name = "John Doe",
                Password = "1234",
                Role = UserRolesEnum.ADMIN,
                Email = "john@doe.me",
                FacultyNumber = "1234567890",
                Expires = DateTime.Now.AddYears(10)
            };
            var student = new DatabaseUser()
            {
                Uid = 2,
                Id = 2,
                Name = "Testic Testevic",
                Password = "brovski",
                Email = "testevic@tu-sofia.bg",
                Role = UserRolesEnum.STUDENT,
                FacultyNumber = "1234567890",
                Expires = DateTime.Now.AddYears(20)
            };
            var professor = new DatabaseUser()
            {
                Uid = 3,
                Id = 3,
                Name = "Test Testov",
                Password = "TrudnaParola20242025",
                Email = "ttestov@tu-sofia.bg",
                Role = UserRolesEnum.PROFESSOR,
                FacultyNumber = "1234567890",
                Expires = DateTime.Now.AddYears(50)
            };

            modelBuilder.Entity<DatabaseUser>().HasData(admin);
            modelBuilder.Entity<DatabaseUser>().HasData(student);
            modelBuilder.Entity<DatabaseUser>().HasData(professor);
        }
    }
}
