using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Openskill.DataAccess.Infrastructure
{
    internal class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            // Here you can replace it with actual connection string.
            optionsBuilder.UseNpgsql("Server=ec2-54-157-16-196.compute-1.amazonaws.com;Port=5432;Database=de1smbrq54gv2o;User Id=itstehpmfeibwd;Password=3342fbbbabd830b0cef31839c3ce462bf5b77f171b3069742713ea21c57a056a");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
