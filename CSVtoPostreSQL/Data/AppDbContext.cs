using CSVtoPostreSQL.Data.Configuration;
using CSVtoPostreSQL.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace CSVtoPostreSQL.Data
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Config.ConnectionString);
        }

        public DbSet<Offer> Offers { get; set; }

    }
}
