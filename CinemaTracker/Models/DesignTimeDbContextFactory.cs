using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CinemaTracker.Models
{
    public class CinemaTrackerContextFactory : IDesignTimeDbContextFactory<CinemaTrackerContext>
    {

        CinemaTrackerContext IDesignTimeDbContextFactory<CinemaTrackerContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<CinemaTrackerContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

            return new CinemaTrackerContext(builder.Options);
        }
    }
}