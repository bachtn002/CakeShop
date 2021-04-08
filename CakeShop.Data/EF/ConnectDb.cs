using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CakeShop.Data.EF
{
    public class ConnectDb : IDesignTimeDbContextFactory<CakeShopDbContext>
    {
        public CakeShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var conn = config.GetConnectionString("CakeShopDb");
            var optionsBuilder = new DbContextOptionsBuilder<CakeShopDbContext>();
            optionsBuilder.UseSqlServer(conn);
            return new CakeShopDbContext(optionsBuilder.Options);
        }
    }
}
