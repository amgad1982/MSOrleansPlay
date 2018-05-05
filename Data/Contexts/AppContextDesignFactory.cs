
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Data.Contexts
{
    public class AppContextDesignFactory : IDesignTimeDbContextFactory<AppSqlContext>
    {
        public AppSqlContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppSqlContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=BackendDb;uid=sa;pwd=get@get1;");

            return new AppSqlContext(optionsBuilder.Options);
        }
    }
}