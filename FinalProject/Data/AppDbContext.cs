using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet <Comment> comment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace with your connection string.
            var connectionString = "server=localhost;user=root1;password=12345;database=myblogdb";

            var serverVersion = new MySqlServerVersion(new Version(10, 4, 28));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}


