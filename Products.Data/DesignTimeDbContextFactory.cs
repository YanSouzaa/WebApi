using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Products_Data
{
    public class ConnectionContextFactory : IDesignTimeDbContextFactory<ConnectionContext>
    {
        public ConnectionContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ConnectionContext>();
            optionsBuilder.UseNpgsql(connectionString);

            return new ConnectionContext(optionsBuilder.Options);
        }
    }
}
