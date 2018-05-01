using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace suggestionspa.Persistence
{
    public class SuggestionspaDbContextFactory : IDesignTimeDbContextFactory<SuggestionspaDbContext>
    {
        public SuggestionspaDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json")
                .Build();
                      
            var builder = new DbContextOptionsBuilder<SuggestionspaDbContext>();

            var connectionString = configuration.GetConnectionString("default");

            builder.UseSqlServer(connectionString);

            return new SuggestionspaDbContext(builder.Options);
        }
    }
}